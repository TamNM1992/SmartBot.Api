using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartBot.DataDto.Script
{
    public class ScriptImportExcelDto
    {
        public string Name { get; set; }
        public int IdUser { get; set; }
        public string HwId { get; set; }
        public List<ActionImportExcelDto> ListAction {  get; set; }
    }
    public class ActionImportExcelDto
    {
        public int SequenceNumber {  get; set; }
        public string Account { get; set; }
        public string? Password { get; set; }
        public string? Profile { get; set; }
        public string Action { get; set; }
        public string? Content { get; set; }
        public string? ImgPath { get; set; }
        public int? TargetActionIndex { get; set; }
        public string TargetType { get; set; }
        public string? Link {  get; set; }
        public int? NumberGet { get; set; }
        public string? Keyword { get; set; }
    }
}
