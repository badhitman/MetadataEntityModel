using System.Collections.Generic;

namespace MetadataEntityModel
{
    public class BtcTransactionModel : MetadataEntityModel.RootEntityModel
    {
        /// <summary>
        /// Связаные btc выходы
        /// </summary>
        public List<BtcTransactionOutModel> Outputs { get; set; }

        public string TxId { get; set; }

        public double Sum { get; set; }
    }
}
