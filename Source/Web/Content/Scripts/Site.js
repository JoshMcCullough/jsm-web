/// <reference path="Definitions/jQuery/jquery.d.ts" />
/// <reference path="Definitions/Bootstrap/bootstrap.d.ts" />
/// <reference path="InfoSlider.ts" />
var $document = $(document);
var $window = $(window);
var Site = {
    baseUrl: null,
    initializers: new Array(),
    initialize: function (baseUrl) {
        Site.baseUrl = baseUrl;
        for (var i = 0; i < Site.initializers.length; i++)
            Site.initializers[i]();
    },
    printing: {
        $printModal: $("#PrintModal"),
        showPrintModal: function () {
            Site.printing.$printModal.modal({
                keyboard: true
            });
        }
    }
};
//Initialize the nav toggler.
Site.initializers.push(function () {
    $("#navbar-toggle").click(function () {
        $("header nav").toggle({
            duration: 200
        });
    });
});
//Initialize the print modal.
Site.initializers.push(function () {
    $("#DownloadPDFButton").click(function () {
        document.location.href = Site.baseUrl + "Export/PDF";
    });
    if (window.matchMedia) {
        window.matchMedia("print").addListener(function (mql) {
            //It won't match after changing back from print.
            if (!mql.matches)
                Site.printing.showPrintModal();
            else {
                $(".info-slider").each(function () {
                    var infoSlider = $(this).getInfoSlider();
                    if (infoSlider.onSliding instanceof Function)
                        infoSlider.onSliding();
                });
            }
        });
    }
    else if (window.onafterprint)
        $(window).on("afterprint", Site.printing.showPrintModal);
});
//Initialize the message modal.
Site.initializers.push(function () {
    var messageModal = $("#MessageModal");
    if (messageModal.length > 0) {
        messageModal.modal({
            keyboard: true
        });
    }
});
//# sourceMappingURL=Site.js.map