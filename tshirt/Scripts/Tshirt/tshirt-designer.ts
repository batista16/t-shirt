module Tshirt.Designer {
    export class DesignerHandler {
        constructor() {
            this.init();
        }
        private static designerSel: string = ".productDesigner";
        private static productTypeSel: string = ".productType";
        private static productColorBlockSel: string = ".productColorBlock";

        private init() {
            this.bindEvents();

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
    }

}