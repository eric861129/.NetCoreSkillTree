/// <summary>
    /// 傳回結果
    /// </summary>
    public class ResultItem
    {
        public ResultItem()
        {
        }
        public ResultItem(List<ResultDetailInfo> ResultDetailInfos)
        {
            this.ResultDetailInfos = ResultDetailInfos;
        }
        /// <summary>
        /// 是否成功
        /// </summary>
        public bool IsSuccess { get; set; }
        /// <summary>
        /// 訊息
        /// </summary>
        public string MainMessage { get; set; }
        /// <summary>
        /// 錯誤資訊集合
        /// </summary>
        public List<ResultDetailInfo> ResultDetailInfos { get; set; }
        /// <summary>
        /// 設定成功訊息
        /// </summary>
        /// <param name="Message"></param>
        public void SetSuccessMessage(string Message = "成功執行！")
        {
            this.IsSuccess = true;
            this.MainMessage = Message;
        }
        /// <summary>
        /// 設定錯誤訊息
        /// </summary>
        /// <param name="ErrorMessage"></param>
        public void SetErrorMessage(string ErrorMessage)
        {
            this.IsSuccess = false;
            this.MainMessage = ErrorMessage;
        }

    }