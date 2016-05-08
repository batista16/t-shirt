/// <reference path="../typings/raphael/raphael.d.ts"/>
module Tshirt.Designer {
    export class DesignerHandler {
        constructor() {
            this.init();
        }
        private static designerSel: string = ".productDesigner";
        private static productTypeSel: string = ".productType";
        private static productColorBlockSel: string = ".productColorBlock";

        private paper;

        private init() {
            this.bindEvents();
            this.initDesignerPaper();
        }

        private bindEvents() {
            $(DesignerHandler.productTypeSel, DesignerHandler.designerSel).off("click").on("click", this.selectProduct);
        }


        private selectProduct() {
            var elem = $(this);
            $(".selected", DesignerHandler.designerSel).removeClass("selected");
            elem.addClass("selected");
            var sel = elem.data("id");
            $(DesignerHandler.productColorBlockSel, DesignerHandler.designerSel).removeClass("active");
            $(DesignerHandler.productColorBlockSel + "[data-type=" + sel + "]", DesignerHandler.designerSel).addClass("active");
        }

        private initDesignerPaper() {
            var paperWidth = $("#designerPaper").width();
            var paperHeight = $("#designerPaper").height();
            var printableWidth = paperWidth / 2.4;
            var printableHeight = (printableWidth / 2) * 3;
            this.paper = Raphael("designerPaper", null, null, null);
            var printableArea = this.paper.rect(
                (paperWidth / 2) - (printableWidth / 2),
                (paperHeight / 2) - (printableHeight / 2),
                printableWidth,
                printableHeight, 0);


            var ro = this.paper.image("https://upload.wikimedia.org/wikipedia/commons/thumb/f/fb/718smiley.svg/1200px-718smiley.svg.png", (paperWidth / 2) - 50, (paperHeight / 2)-50, 100, 100);
            this.paper.freeTransform(ro);
            printableArea.toFront();
        }
    }

}