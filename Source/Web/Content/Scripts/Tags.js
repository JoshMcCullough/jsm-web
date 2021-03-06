var __extends = (this && this.__extends) || (function () {
    var extendStatics = function (d, b) {
        extendStatics = Object.setPrototypeOf ||
            ({ __proto__: [] } instanceof Array && function (d, b) { d.__proto__ = b; }) ||
            function (d, b) { for (var p in b) if (b.hasOwnProperty(p)) d[p] = b[p]; };
        return extendStatics(d, b);
    };
    return function (d, b) {
        extendStatics(d, b);
        function __() { this.constructor = d; }
        d.prototype = b === null ? Object.create(b) : (__.prototype = b.prototype, new __());
    };
})();
var Tags = /** @class */ (function () {
    function Tags(container) {
        var _this = this;
        this.container = container;
        this.tags = new Array();
        this.displayProperty = "abbreviation";
        var tagString = container.data(Tags.dataTagsKeysKey);
        if (tagString != null) {
            var tagKeys = tagString.split(" ");
            tagKeys.forEach(function (key) {
                var tag = $.grep(Tags.allTags, function (tag) { return tag.key == key; }).shift();
                if (tag == null) {
                    console.log("Unknown tag \"" + key + "\".");
                }
                else {
                    _this.tags.push(tag);
                }
            }, this);
            this.createElements();
        }
        container.data(Tags.dataTagsKey, this);
    }
    Tags.prototype.createElements = function () {
        var _this = this;
        this.tags.forEach(function (tag) {
            tag.element = $("<li>")
                .addClass("tag " + tag.key)
                .css("background-color", tag.color.toCss())
                .data(Tags.dataTagKey, tag)
                .attr("title", tag.name)
                .attr("data-tags-key", tag.key)
                .attr("data-tags-abbr", tag.abbreviation)
                .attr("data-tags-name", tag.name)
                .attr("data-tags-exp", tag.expertise)
                .append($("<span>")
                .text(tag[_this.displayProperty]))
                .append(tag.expertise != null ? $("<span>")
                .addClass("rank")
                .text(tag.expertise) : null);
            _this.container.append(tag.element);
        }, this);
    };
    Tags.init = function () {
        Tags.colorizeTags(Tags.allTags);
    };
    Tags.colorizeTags = function (tags) {
        var colors = Tags.getColors(tags.length);
        tags.forEach(function (tag, index) {
            var colorIndex = ((index % 2) * (colors.length - 1));
            var color = colors.splice(colorIndex, 1)[0];
            tag.color = color;
        }, this);
    };
    Tags.getColors = function (count) {
        var valueMin = 20;
        var valueMax = 80;
        var valueCount = 5;
        var valueStep = ((valueMax - valueMin) / (valueCount - 1));
        var hueMax = 360;
        var hueStep = (hueMax / ((count - 1) / valueCount));
        var colors = new Array();
        for (var v = valueMin; v <= valueMax; v += valueStep) {
            for (var h = 0; h <= hueMax; h += hueStep) {
                var rgb = Tags.convertHsvToRgb(h, 100, v);
                colors.push(rgb);
            }
        }
        return colors;
    };
    // Based on: http://axonflux.com/handy-rgb-to-hsl-and-rgb-to-hsv-color-model-c
    Tags.convertHsvToRgb = function (h, s, v) {
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
            case 0:
                r = v;
                g = t;
                b = p;
                break;
            case 1:
                r = q;
                g = v;
                b = p;
                break;
            case 2:
                r = p;
                g = v;
                b = t;
                break;
            case 3:
                r = p;
                g = q;
                b = v;
                break;
            case 4:
                r = t;
                g = p;
                b = v;
                break;
            case 5:
                r = v;
                g = p;
                b = q;
                break;
        }
        r = Math.floor(r * 255);
        g = Math.floor(g * 255);
        b = Math.floor(b * 255);
        return new Rgb(r, g, b);
    };
    Tags.dataTagsKey = "tags";
    Tags.dataTagsKeysKey = "tags-keys";
    Tags.dataTagKey = "tags";
    Tags.allTags = new Array();
    return Tags;
}());
var ExpertiseLayoutMode;
(function (ExpertiseLayoutMode) {
    ExpertiseLayoutMode[ExpertiseLayoutMode["Linear"] = 0] = "Linear";
})(ExpertiseLayoutMode || (ExpertiseLayoutMode = {}));
var Expertise = /** @class */ (function (_super) {
    __extends(Expertise, _super);
    function Expertise(container, options) {
        if (options === void 0) { options = null; }
        var _this = _super.call(this, container) || this;
        _this.container = container;
        _this.minSize = 30;
        _this.maxSize = 100;
        _this.fixedHeight = null;
        _this.padding = 4;
        _this.layouts = {};
        _this.displayProperty = "name";
        _this.layoutMode = ExpertiseLayoutMode.Linear;
        _this.tags = $.grep(Tags.allTags, function (tag) { return tag.expertise != null; });
        _this.initLayouts();
        $.extend(true, _this, options);
        _this.orderTags();
        _this.sizeTags();
        _this.createElements();
        $(document).ready(function () {
            this.layoutTags();
            this.registerEvents();
        }.bind(_this));
        return _this;
    }
    Expertise.prototype.initLayouts = function () {
        this.layouts[ExpertiseLayoutMode.Linear] = {
            func: this.layoutTagsLinear,
            options: new LinearLayoutOptions()
        };
    };
    Expertise.prototype.orderTags = function () {
        this.tags.sort(function (a, b) {
            if (a.expertise == b.expertise)
                return a.name.localeCompare(b.name);
            else if (a.expertise < b.expertise)
                return 1;
            return -1;
        });
    };
    Expertise.prototype.sizeTags = function () {
        var _this = this;
        var sizeRange = (this.maxSize - this.minSize);
        var values = this.tags.map(function (tag) { return tag.expertise; });
        var min = Math.min.apply(Math, values);
        var max = Math.max.apply(Math, values);
        var range = (max - min);
        this.tags.forEach(function (tag) {
            var expertise = tag.expertise;
            var relativeExpertise = ((expertise - min) / range);
            var size = Math.floor(_this.minSize + (relativeExpertise * sizeRange));
            tag.size = size;
        }, this);
    };
    Expertise.prototype.layoutTags = function () {
        this.layouts[this.layoutMode].func.call(this, this.layouts[this.layoutMode].options);
    };
    Expertise.prototype.layoutTagsLinear = function (options) {
        var _this = this;
        var firstTag = this.tags[0];
        var tagPaddingTop = parseInt(firstTag.element.css("padding-top"));
        var tagWidthOffset = (firstTag.element.outerWidth() - firstTag.element.width());
        var tagHeightOffset = (firstTag.element.outerHeight() - firstTag.element.height());
        var currentSize = null;
        var maxRowHeight = null;
        var top = 0;
        var left = 0;
        var zIndex = this.tags.length;
        var availableWidth = this.container.innerWidth();
        this.tags.forEach(function (tag, index) {
            var nextTop = (top + maxRowHeight + _this.padding);
            if (currentSize == null || currentSize != tag.size) {
                if (currentSize != null && options.linePerLevel === true)
                    top = nextTop;
                currentSize = tag.size;
                maxRowHeight = (_this.fixedHeight || Math.max(maxRowHeight, currentSize));
                if (options.linePerLevel === true)
                    left = 0;
            }
            if ((left + currentSize) > availableWidth) {
                top = nextTop;
                maxRowHeight = (_this.fixedHeight || currentSize);
                left = 0;
            }
            tag.element.css("line-height", ((_this.fixedHeight || currentSize) - tagHeightOffset) + "px");
            tag.element.css("z-index", zIndex);
            tag.element.delay(index * options.animationDelay).animate({
                width: (currentSize),
                height: (_this.fixedHeight || currentSize),
                minWidth: (currentSize),
                minHeight: (_this.fixedHeight || currentSize),
                top: top,
                left: left,
                opacity: 1
            }, {
                duration: options.animationDuration,
                easing: options.animationEasing
            });
            left += (currentSize + _this.padding);
            zIndex--;
        }, this);
        this.container.height(top + maxRowHeight);
    };
    Expertise.prototype.registerEvents = function () {
        $(window).resize(this.layoutTags.bind(this));
    };
    return Expertise;
}(Tags));
var LayoutOptions = /** @class */ (function () {
    function LayoutOptions(options) {
        if (options === void 0) { options = null; }
        this.animationDelay = 50;
        this.animationDuration = 300;
        this.animationEasing = "easeOutQuart";
    }
    return LayoutOptions;
}());
var LinearLayoutOptions = /** @class */ (function (_super) {
    __extends(LinearLayoutOptions, _super);
    function LinearLayoutOptions(options) {
        if (options === void 0) { options = null; }
        var _this = _super.call(this, null) || this;
        _this.linePerLevel = true;
        $.extend(true, _this, options);
        return _this;
    }
    return LinearLayoutOptions;
}(LayoutOptions));
var Tag = /** @class */ (function () {
    function Tag(key, abbreviation, name, expertise) {
        if (name === void 0) { name = null; }
        if (expertise === void 0) { expertise = null; }
        this.key = key;
        this.abbreviation = abbreviation;
        this.name = name;
        this.expertise = expertise;
        this.color = null;
        this.element = null;
        this.size = null;
        if (abbreviation == null) {
            this.abbreviation = (this.name || this.key);
        }
        if (name == null) {
            this.name = (this.abbreviation || this.key);
        }
    }
    return Tag;
}());
var Rgb = /** @class */ (function () {
    function Rgb(r, g, b) {
        this.r = r;
        this.g = g;
        this.b = b;
    }
    Rgb.prototype.toCss = function () {
        return "rgb(" + this.r + ", " + this.g + ", " + this.b + ")";
    };
    return Rgb;
}());
jQuery.fn.extend({
    tags: function () {
        $(this).each(function () {
            new Tags($(this));
        });
    },
    getTags: function () {
        return $(this).data(Tags.dataTagsKey);
    },
    expertise: function (options) {
        if (options === void 0) { options = null; }
        $(this).each(function () {
            new Expertise($(this), options);
        });
    },
    getExpertise: function () {
        return $(this).data(Expertise.dataTagsKey);
    },
});
Tags.allTags.push(new Tag("azure", null, "Azure", 5));
Tags.allTags.push(new Tag("couchdb", null, "CouchDB", 5));
Tags.allTags.push(new Tag("elasticsearch", null, "Elasticsearch", 7));
Tags.allTags.push(new Tag("microservices", null, "Microservices", 7));
Tags.allTags.push(new Tag("node", null, "Node/NPM", 7));
Tags.allTags.push(new Tag("typescript", null, "TypeScript", 9));
Tags.allTags.push(new Tag("aws", "AWS", "Amazon Web Services", 7));
Tags.allTags.push(new Tag("apache2", null, "Apache2", 5));
Tags.allTags.push(new Tag("arcgis", null, "ArcGIS", 3));
Tags.allTags.push(new Tag("arduino", null, "Arduino", 4));
Tags.allTags.push(new Tag("mvc", "MVC", "ASP.NET MVC", 8));
Tags.allTags.push(new Tag("webforms", "WebForms", "WebForms", 7));
Tags.allTags.push(new Tag("webapi2", null, "Web API 2", 9));
Tags.allTags.push(new Tag("aurelia", null, "Aurelia", 8));
Tags.allTags.push(new Tag("bs", null, "Bootstrap", 8));
Tags.allTags.push(new Tag("mdl", null, "Google MDL", 6));
Tags.allTags.push(new Tag("cs", null, "C#", 9));
Tags.allTags.push(new Tag("cpp", null, "C++", 3));
Tags.allTags.push(new Tag("css", null, "CSS", 9));
Tags.allTags.push(new Tag("di", null, "Dependency Injection", 9));
Tags.allTags.push(new Tag("flash", null, "Flash", 3));
Tags.allTags.push(new Tag("git", null, "Git", 8));
Tags.allTags.push(new Tag("grails", null, "Grails", 3));
Tags.allTags.push(new Tag("highcharts", null, "Highcharts", 4));
Tags.allTags.push(new Tag("highmaps", null, "Highmaps", 4));
Tags.allTags.push(new Tag("html", null, "HTML/5", 9));
Tags.allTags.push(new Tag("iis", null, "IIS", 7));
Tags.allTags.push(new Tag("java", null, "Java", 9));
Tags.allTags.push(new Tag("js", "JS", "JavaScript", 9));
Tags.allTags.push(new Tag("ko", null, "Knockout", 6));
Tags.allTags.push(new Tag("linux", null, "Linux", 7));
Tags.allTags.push(new Tag("mantis", null, "Mantis", 6));
Tags.allTags.push(new Tag("mssql", "MS SQL", "SQL Server", 9));
Tags.allTags.push(new Tag("ssrs", null, "Microsoft SSRS", 6));
Tags.allTags.push(new Tag("mysql", null, "My SQL", 8));
Tags.allTags.push(new Tag("openscad", null, "OpenSCAD", 3));
Tags.allTags.push(new Tag("oracle", null, "Oracle", 5));
Tags.allTags.push(new Tag("php", null, "PHP", 4));
Tags.allTags.push(new Tag("python", null, "Python", 2));
Tags.allTags.push(new Tag("redmine", null, "Redmine", 4));
Tags.allTags.push(new Tag("regex", "RegEx", "Regular Expressions", 9));
Tags.allTags.push(new Tag("rails", "Rails", "Ruby on Rails", 6));
Tags.allTags.push(new Tag("sl", null, "Silverlight", 4));
Tags.allTags.push(new Tag("svn", "SVN", "Subversion", 8));
Tags.allTags.push(new Tag("tfs", "TFS", "Team Foundation Server", 6));
Tags.allTags.push(new Tag("tfvc", "TFVC", "TF Version Control", 7));
Tags.allTags.push(new Tag("tomcat", null, "Tomcat", 4));
Tags.allTags.push(new Tag("uiux", null, "UI/UX", 7));
Tags.allTags.push(new Tag("testing", null, "Unit Testing", 9));
Tags.allTags.push(new Tag("vb", "VB.NET", "Visual Basic .NET", 5));
Tags.allTags.push(new Tag("weblogic", null, "WebLogic", 3));
Tags.allTags.push(new Tag("windows", null, "Windows", 9));
Tags.allTags.push(new Tag("wcf", "WCF", "WCF", 7));
Tags.allTags.push(new Tag("winforms", "WinForms", "Windows Forms", 6));
Tags.allTags.push(new Tag("winserver", null, "Windows Server", 7));
Tags.allTags.push(new Tag("xml", null, "XML", 7));
Tags.allTags.push(new Tag("xsd", null, "XSD", 6));
Tags.allTags.push(new Tag("xslt", null, "XSLT", 7));
Tags.allTags.push(new Tag("react", null, "React", 7));
Tags.allTags.push(new Tag("redux", null, "Redux", 7));
Tags.allTags.push(new Tag("hibernate", null, "Hibernate", 6));
Tags.allTags.push(new Tag("flyway", null, "Flyway", 8));
Tags.init();
//# sourceMappingURL=Tags.js.map