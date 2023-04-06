using System.ComponentModel.DataAnnotations;

namespace _1.C_Example.Enum
{

    /// <summary>
    /// 幣別代碼
    /// </summary>
    public enum Currency
    {
        /// <summary>
        /// 台幣
        /// </summary>
        [Display(Name = "台幣", ShortName = "zh-tw")]
        NTD = 1,
        /// <summary>
        /// 美金
        /// </summary>
        [Display(Name = "美金", ShortName = "en-us")]
        USD = 2,
        /// <summary>
        /// 人民幣
        /// </summary>
        [Display(Name = "人民幣", ShortName = "zh-cn")]
        CNY = 3,
        /// <summary>
        /// 日幣
        /// </summary>
        [Display(Name = "日幣", ShortName = "ja-jp")]
        JPY = 4,
    }
}
