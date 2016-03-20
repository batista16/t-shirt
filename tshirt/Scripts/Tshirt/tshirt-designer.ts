module Tshirt.Designer {
    export class DesignerHandler {
        constructor() {
            this.init();
        }
        private designerSel: string =".productDesigner";
        private productTypeSel: string = ".productType";

        private init() {
            this.bindEvents();

        }

        private bindEvents() {
            $(this.productTypeSel, this.designerSel).off("click").on("click", this.selectProduct);
        }


        private selectProduct(event) {
            alert(event.target);
        }
    }
    
}