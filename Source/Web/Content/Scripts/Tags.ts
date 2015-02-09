﻿class Tags {
    static dataTagsKey = "tags";
    static dataTagsKeysKey = "tags-keys";
    static dataTagKey = "tags";
    static allTags = new Array<Tag>();

    public tags = new Array<Tag>();
    public displayProperty = "abbreviation";

    constructor(public container: JQuery) {
        var tagString = container.data(Tags.dataTagsKeysKey);

        if (tagString != null) {
            var tagKeys = tagString.split(" ");

            tagKeys.forEach((key) => {
                var tag = $.grep(Tags.allTags, (tag) => tag.key == key).shift();

                if (tag == null)
                    console.log("Unknown tag \"" + key + "\".");

                this.tags.push(tag);
            }, this);

            this.createElements();
        }

        container.data(Tags.dataTagsKey, this);
    }

    protected createElements(): void {
        this.tags.forEach((tag) => {
            tag.element = $("<li>")
                .addClass("tag " + tag.key)
                .css("background-color", tag.color.toCss())
                .attr("title", tag.name)
                .data(Tags.dataTagKey, tag)
                .append($("<span>")
                    .text(tag[this.displayProperty]))
                .append(tag.expertise != null ? $("<span>")
                    .addClass("rank")
                    .text(tag.expertise) : null);

            this.container.append(tag.element);
        }, this);
    }

    public static init(): void {
        Tags.colorizeTags(Tags.allTags);
    }

    private static colorizeTags(tags: Array<Tag>): void {
        var colors = Tags.getColors(tags.length);

        tags.forEach((tag, index) => {
            var colorIndex = ((index % 2) * (colors.length - 1));
            var color = colors.splice(colorIndex, 1)[0];

            tag.color = color;
        }, this);
    }

    private static getColors(count: number): Array<Rgb> {
        var valueMin = 20;
        var valueMax = 80;
        var valueCount = 5;
        var valueStep = ((valueMax - valueMin) / (valueCount - 1));
        var hueMax = 360;
        var hueStep = (hueMax / ((count - 1) / valueCount));
        var colors = new Array<Rgb>();

        for (var v = valueMin; v <= valueMax; v += valueStep) {
            for (var h = 0; h <= hueMax; h += hueStep) {
                var rgb = Tags.convertHsvToRgb(h, 100, v);

                colors.push(rgb);
            }
        }

        return colors;
    }

    // Based on: http://axonflux.com/handy-rgb-to-hsl-and-rgb-to-hsv-color-model-c
    private static convertHsvToRgb(h: number, s: number, v: number): Rgb {
        var r, g, b, i, f, p, q, t;

        h /= 360;
        s /= 100;
        v /= 100;
        i = Math.floor(h * 6);
        f = ((h * 6) - i);
        p = (v * (1 - s));
        q = (v * (1 - f * s));
        t = (v * (1 - (1 - f) * s));

        switch (i % 6) {
            case 0: r = v; g = t; b = p; break;
            case 1: r = q; g = v; b = p; break;
            case 2: r = p; g = v; b = t; break;
            case 3: r = p; g = q; b = v; break;
            case 4: r = t; g = p; b = v; break;
            case 5: r = v; g = p; b = q; break;
        }

        r = Math.floor(r * 255);
        g = Math.floor(g * 255);
        b = Math.floor(b * 255);

        return new Rgb(r, g, b);
    }
}

enum ExpertiseLayoutMode {
    Linear
}

class Expertise extends Tags {
    private minSize = 30;
    private maxSize = 100;
    private padding = 4;
    private layouts = {};

    public displayProperty = "name";
    public layoutMode = ExpertiseLayoutMode.Linear;

    constructor(public container: JQuery, options: Object = null) {
        super(container);

        this.tags = $.grep(Tags.allTags, (tag) => tag.expertise != null);
        this.initLayouts();

        $.extend(true, this, options);

        this.orderTags();
        this.sizeTags();
        this.createElements();

        $(document).ready(function () {
            this.layoutTags();
            this.registerEvents();
        }.bind(this));
    }

    private initLayouts() {
        this.layouts[ExpertiseLayoutMode.Linear] = {
            func: this.layoutTagsLinear,
            options: new LinearLayoutOptions()
        };
    }

    public orderTags(): void {
        this.tags.sort((a, b) => {
            if (a.expertise == b.expertise)
                return a.name.localeCompare(b.name);
            else if (a.expertise < b.expertise)
                return 1;

            return -1;
        });
    }

    public sizeTags(): void {
        var sizeRange = (this.maxSize - this.minSize);
        var values = this.tags.map((tag) => tag.expertise);
        var min = Math.min.apply(Math, values);
        var max = Math.max.apply(Math, values);
        var range = (max - min);

        this.tags.forEach((tag) => {
            var expertise = tag.expertise;
            var relativeExpertise = ((expertise - min) / range);
            var size = Math.floor(this.minSize + (relativeExpertise * sizeRange));

            tag.size = size;
        }, this);
    }

    public layoutTags(): void {
        this.layouts[this.layoutMode].func.call(this, this.layouts[this.layoutMode].options);
    }

    private layoutTagsLinear(options: LinearLayoutOptions): void {
        var firstTag = this.tags[0];
        var tagPaddingTop = parseInt(firstTag.element.css("padding-top"));
        var tagWidthOffset = (firstTag.element.outerWidth() - firstTag.element.width());
        var tagHeightOffset = (firstTag.element.outerHeight() - firstTag.element.height());
        var currentSize = null;
        var maxRowHeight = null;
        var top = 0;
        var left = 0;
        var availableWidth = this.container.innerWidth();

        this.tags.forEach((tag, index) => {
            var nextTop = (top + maxRowHeight + this.padding);

            if (currentSize == null || currentSize != tag.size) {
                if (currentSize != null && options.linePerLevel === true)
                    top = nextTop;

                currentSize = tag.size;
                maxRowHeight = Math.max(maxRowHeight, currentSize);

                if (options.linePerLevel === true)
                    left = 0;
            }

            if ((left + currentSize) > availableWidth) {
                top = nextTop;
                maxRowHeight = currentSize;
                left = 0;
            }

            tag.element.css("line-height", (currentSize - tagHeightOffset - (2 * tagPaddingTop)) + "px");
            tag.element.delay(index * options.animationDelay).animate({
                width: (currentSize),
                height: (currentSize),
                minWidth: (currentSize),
                minHeight: (currentSize),
                top: (top + ((maxRowHeight - currentSize) / 2)),
                left: left,
                opacity: 1
            }, {
                duration: options.animationDuration,
                easing: options.animationEasing
            });

            left += (currentSize + this.padding);
        }, this);

        this.container.height(top + currentSize);
    }

    private registerEvents() {
        $(window).resize(this.layoutTags.bind(this));
    }
}

class LayoutOptions {
    public animationDelay = 50;
    public animationDuration = 800;
    public animationEasing = "easeOutQuart";

    constructor(options: Object = null) {
    }
}

class LinearLayoutOptions extends LayoutOptions {
    public linePerLevel = true;

    constructor(options: Object = null) {
        super(null);
        $.extend(true, this, options);
    }
}

class Tag {
    public color: Rgb = null;
    public element: JQuery = null;
    public size: number = null;

    constructor(public key: string, public abbreviation: string, public name: string = null, public expertise: number = null) {
        if (abbreviation == null)
            this.abbreviation = (this.name || this.key);

        if (name == null)
            this.name = (this.abbreviation || this.key);
    }
}

class Rgb {
    constructor(public r: number, public g: number, public b: number) {
    }

    public toCss(): string {
        return "rgb(" + this.r + ", " + this.g + ", " + this.b + ")";
    }
}

jQuery.fn.extend({
    tags: function () {
        $(this).each(function () {
            new Tags($(this));
        });
    },
    getTags: function () {
        return $(this).data(Tags.dataTagsKey);
    },
    expertise: function (options: Object = null) {
        $(this).each(function () {
            new Expertise($(this), options);
        });
    },
    getExpertise: function () {
        return $(this).data(Expertise.dataTagsKey);
    },
});

Tags.allTags.push(new Tag("aws", "AWS", "Amazon Web Services", 7));
Tags.allTags.push(new Tag("apache2", null, "Apache2", 6));
Tags.allTags.push(new Tag("api", "API", "API"));
Tags.allTags.push(new Tag("arcgis", null, "ArcGIS", 3));
Tags.allTags.push(new Tag("arduino", null, "Arduino", 4));
Tags.allTags.push(new Tag("webforms", "WebForms", "ASP.NET WebForms", 10));
Tags.allTags.push(new Tag("ontime", "OnTime", "Axosoft OnTime", 7));
Tags.allTags.push(new Tag("bs", null, "Bootstrap", 8));
Tags.allTags.push(new Tag("cs", null, "C#", 10));
Tags.allTags.push(new Tag("cpp", null, "C++", 3));
Tags.allTags.push(new Tag("css", null, "CSS", 10));
Tags.allTags.push(new Tag("css3", null, "CSS3", 10));
Tags.allTags.push(new Tag("flash", null, "Flash", 3));
Tags.allTags.push(new Tag("git", null, "Git", 7));
Tags.allTags.push(new Tag("grails", null, "Grails", 3));
Tags.allTags.push(new Tag("html", null, "HTML", 10));
Tags.allTags.push(new Tag("html5", null, "HTML5", 10));
Tags.allTags.push(new Tag("iis", "IIS", "Internet Information Services", 10));
Tags.allTags.push(new Tag("java", null, "Java", 7));
Tags.allTags.push(new Tag("js", "JS", "JavaScript", 10));
Tags.allTags.push(new Tag("ko", null, "Knockout", 7));
Tags.allTags.push(new Tag("linux", null, "Linux", 6));
Tags.allTags.push(new Tag("mantis", null, "Mantis", 6));
Tags.allTags.push(new Tag("mapping", null, "Mapping", 6));
Tags.allTags.push(new Tag("mssql", "MS SQL", "Microsoft SQL Server", 9));
Tags.allTags.push(new Tag("mvc", "MVC", "ASP.NET MVC", 10));
Tags.allTags.push(new Tag("msoffice", null, "MS Office", 6));
Tags.allTags.push(new Tag("mysql", null, "My SQL", 7));
Tags.allTags.push(new Tag("openscad", null, "OpenSCAD", 3));
Tags.allTags.push(new Tag("oracle", null, "Oracle", 5));
Tags.allTags.push(new Tag("php", null, "PHP", 5));
Tags.allTags.push(new Tag("python", null, "Python", 2));
Tags.allTags.push(new Tag("redmine", null, "Redmine", 6));
Tags.allTags.push(new Tag("regex", "RegEx", "Regular Expressions", 9));
Tags.allTags.push(new Tag("rails", "Rails", "Ruby on Rails", 6));
Tags.allTags.push(new Tag("sl", null, "Silverlight", 4));
Tags.allTags.push(new Tag("svn", "SVN", "Subversion", 9));
Tags.allTags.push(new Tag("svg", null, "SVG", 7));
Tags.allTags.push(new Tag("tfs", "TFS", "Team Foundation Server", 9));
Tags.allTags.push(new Tag("tfvc", "TFVC", "Team Foundation Version Control", 7));
Tags.allTags.push(new Tag("tomcat", null, "Tomcat", 7));
Tags.allTags.push(new Tag("uiux", null, "UI/UX", 7));
Tags.allTags.push(new Tag("vb", "VB.NET", "Visual Basic .NET", 8));
Tags.allTags.push(new Tag("weblogic", null, "WebLogic", 10));
Tags.allTags.push(new Tag("windows", null, "Windows", 10));
Tags.allTags.push(new Tag("wcf", "WCF", "Windows Communication Foundation", 7));
Tags.allTags.push(new Tag("winforms", "WinForms", "Windows Forms", 10));
Tags.allTags.push(new Tag("wp", null, "Windows Phone", 4));
Tags.allTags.push(new Tag("xml", null, "XML", 10));
Tags.allTags.push(new Tag("xsd", null, "XSD", 7));
Tags.allTags.push(new Tag("xslt", null, "XSLT", 9));


Tags.init();