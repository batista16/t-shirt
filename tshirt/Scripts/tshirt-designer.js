var Tshirt;
(function (Tshirt) {
    var Designer;
    (function (Designer) {
        var DesignerHandler = (function () {
            function DesignerHandler() {
                this.designerSel = ".productDesigner";
                this.productTypeSel = ".productType";
                this.init();
            }
            DesignerHandler.prototype.init = function () {
                this.bindEvents();
            };
            DesignerHandler.prototype.bindEvents = function () {
                $(this.productTypeSel, this.designerSel).off("click").on("click", this.selectProduct);
            };
            DesignerHandler.prototype.selectProduct = function (event) {
                alert(event.target);
            };
            return DesignerHandler;
        })();
        Designer.DesignerHandler = DesignerHandler;
    })(Designer = Tshirt.Designer || (Tshirt.Designer = {}));
})(Tshirt || (Tshirt = {}));
//# sourceMappingURL=tshirt-designer.js.map