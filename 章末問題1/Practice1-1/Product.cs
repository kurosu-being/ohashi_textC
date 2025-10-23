
namespace ProductNamespace {
    /// <summary>
    /// 商品情報を管理するクラス
    /// </summary>
    internal class Product {
        /// <summary>
        /// 商品コードを保持するプロパティ※問題では使用しない
        /// </summary>
        public int Code { get; private set; }
        /// <summary>
        /// 商品名を保持するプロパティ※問題では使用しない
        /// </summary>
        public string Name { get; private set; }
        /// <summary>
        /// 商品価格を保持するプロパティ
        /// </summary>
        public int Price { get; private set; }
        private const double Tax = 0.08;

        public Product(int vCode, string vName, int vPrice) {
            this.Code = vCode;
            this.Name = vName;
            this.Price = vPrice;
        }
        /// <summary>
        /// 消費税額を取得する
        /// </summary>
        /// <returns>消費税額</returns>
        public int GetTax() {
            return (int)(this.Price * Tax);
        }
    }
}
