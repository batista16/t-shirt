/// <reference path="../typings/raphael/raphael.d.ts"/>
var Tshirt;
(function (Tshirt) {
    var Designer;
    (function (Designer) {
        var DesignerHandler = (function () {
            function DesignerHandler() {
                this.init();
            }
            DesignerHandler.prototype.init = function () {
                this.bindEvents();
                this.initDesignerPaper();
            };
            DesignerHandler.prototype.bindEvents = function () {
                $(DesignerHandler.productTypeSel, DesignerHandler.designerSel).off("click").on("click", this.selectProduct);
            };
            DesignerHandler.prototype.selectProduct = function () {
                var elem = $(this);
                $(".selected", DesignerHandler.designerSel).removeClass("selected");
                elem.addClass("selected");
                var sel = elem.data("id");
                $(DesignerHandler.productColorBlockSel, DesignerHandler.designerSel).removeClass("active");
                $(DesignerHandler.productColorBlockSel + "[data-type=" + sel + "]", DesignerHandler.designerSel).addClass("active");
            };
            DesignerHandler.prototype.initDesignerPaper = function () {
                var paperWidth = $("#designerPaper").width();
                var paperHeight = $("#designerPaper").height();
                var printableWidth = paperWidth / 2.4;
                var printableHeight = (printableWidth / 2) * 3;
                this.paper = Raphael("designerPaper", null, null, null);
                var printableArea = this.paper.rect((paperWidth / 2) - (printableWidth / 2), (paperHeight / 2) - (printableHeight / 2), printableWidth, printableHeight, 0);
                var ro = this.paper.image("https://upload.wikimedia.org/wikipedia/commons/thumb/f/fb/718smiley.svg/1200px-718smiley.svg.png", (paperWidth / 2) - 50, (paperHeight / 2) - 50, 100, 100);
                this.paper.freeTransform(ro);
                printableArea.toFront();
            };
            DesignerHandler.designerSel = ".productDesigner";
            DesignerHandler.productTypeSel = ".productType";
            DesignerHandler.productColorBlockSel = ".productColorBlock";
            return DesignerHandler;
        }());
        Designer.DesignerHandler = DesignerHandler;
    })(Designer = Tshirt.Designer || (Tshirt.Designer = {}));
})(Tshirt || (Tshirt = {}));
//# sourceMappingURL=tshirt-designer.js.map