using Newtonsoft.Json;
using Essensoft.AspNetCore.Alipay.Domain;

namespace Essensoft.AspNetCore.Alipay.Response
{
    /// <summary>
    /// ZhimaCreditEpInfoGetResponse.
    /// </summary>
    public class ZhimaCreditEpInfoGetResponse : AlipayResponse
    {
        /// <summary>
        /// 芝麻信用对于每一次请求返回的业务号。后续可以通过此业务号进行对账
        /// </summary>
        [JsonProperty("biz_no")]
        public string BizNo { get; set; }

        /// <summary>
        /// 企业工商综合信息
        /// </summary>
        [JsonProperty("company_info")]
        public CompanyInfo CompanyInfo { get; set; }
    }
}
