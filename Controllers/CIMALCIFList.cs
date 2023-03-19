using Microsoft.AspNetCore.Mvc;

namespace IMAL_KYC.Controllers
{
    [ApiController]
    [Route("[controller]")]

    public class CIMALCIFList : Controller
    {
        DLL DLLCOde = new DLL();
        [HttpPost(Name = "SIMALCIFList")]
        public ActionResult<string> OnGet([FromBody] SIMALCIFList x)
        {
           
            return DLLCOde.ReturnCIFList(x.MobileNo, x.idNumber, x.username, x.password, System.DateTime.Now.ToString("yyyy-MM-dd" + "T" + "HH:mm:ss"),x.ChannelName);
       
        }
    }
}
