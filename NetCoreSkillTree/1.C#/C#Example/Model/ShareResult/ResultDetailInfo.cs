namespace Example
{
    public class ResultDetailInfo
    {
        /// <summary>
        /// 回傳資訊名稱
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// 回傳訊息
        /// </summary>
        public string ResultMessage { get; set; }
        /// <summary>
        /// 回傳物件類別
        /// </summary>
        public Type ResultType { get; set; }
        /// <summary>
        /// 回傳物件
        /// </summary>
        public object ResultItem { get; set; }
        /// <summary>
        /// 回傳成功?
        /// </summary>
        public bool ResultIsSuccess { get; set; }

        /// <summary>
        /// 設定回傳物件
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="t"></param>
        public void SetResultItem<T>(T t) where T : class
        {
            this.ResultItem = Convert.ChangeType(t, t.GetType());
            this.ResultType = t.GetType();
        }
        /// <summary>
        /// 設定成功回傳
        /// </summary>
        /// <param name="Name"></param>
        /// <param name="ErrorMessage"></param>
        public ResultDetailInfo SetSucessResult(string Name = null, string ErrorMessage = null)
        {
            SetMessage(Name, ErrorMessage);
            this.ResultIsSuccess = true;
            return this;
        }

        /// <summary>
        /// 設定成功回傳
        /// </summary>
        /// <param name="Name"></param>
        /// <param name="ErrorMessage"></param>
        public ResultDetailInfo SetErrorResult(string Name = null, string ErrorMessage = null)
        {
            SetMessage(Name, ErrorMessage);
            this.ResultIsSuccess = false;
            return this;
        }
        /// <summary>
        /// 設定訊息
        /// </summary>
        /// <param name="Name"></param>
        /// <param name="ErrorMessage"></param>
        private void SetMessage(string? Name = null, string ErrorMessage = null)
        {
            this.Name = Name;
            this.ResultMessage = ErrorMessage;
        }
    }
}
