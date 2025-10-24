namespace Practice1_1Product {
    /// <summary>
    /// 商品情報を管理する
    /// </summary>
    internal class Product {
        /// <summary>
        /// 商品コード※問題では使用しない
        /// </summary>
        public int Code { get; private set; }
        /// <summary>
        /// 商品名※問題では使用しない
        /// </summary>
        public string Name { get; private set; }
        /// <summary>
        /// 商品価格
        /// </summary>
        public int Price { get; private set; }

        /// <summary>
        /// 税率
        /// </summary>  
        private const double C_Tax = 0.08;

        /// <summary>
        /// 商品情報を初期化するコンストラクタ
        /// </summary>
        /// <param name="vCode">商品コード</param>
        /// <param name="vName">商品名</param>
        /// <param name="vPrice">商品価格</param>
        public Product(int vCode, string vName, int vPrice) {
            this.Code = vCode;
            this.Name = vName;
            this.Price = vPrice;
        }
        /// <summary>
        /// 消費税額を取得する ※小数点以下は切り捨て
        /// </summary>
        /// <returns>消費税額</returns>
        public int GetTax() {
            return (int)(this.Price * C_Tax);
        }
    }
}
