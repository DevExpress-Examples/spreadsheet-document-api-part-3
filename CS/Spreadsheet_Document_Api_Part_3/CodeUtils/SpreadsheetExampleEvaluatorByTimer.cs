﻿namespace Spreadsheet_Document_Api_Part_3
{
    #region SpreadsheetExampleEvaluatorByTimer
    public class SpreadsheetExampleEvaluatorByTimer : ExampleEvaluatorByTimer
    {
        public SpreadsheetExampleEvaluatorByTimer()
            : base()
        {
        }

        protected override ExampleCodeEvaluator GetExampleCodeEvaluator(ExampleLanguage language)
        {
            if (language == ExampleLanguage.VB)
                return new SpreadsheetVbExampleCodeEvaluator();
            return new SpreadsheetCSExampleCodeEvaluator();
        }
    }
    #endregion
}
