using Microsoft.AspNetCore.Mvc;

namespace IMAL_KYC.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CIMALCIFDTS : Controller
    {
        DLL DLLCOde = new DLL();
        [HttpPost(Name = "SIMALCIFDTS")]
        public ActionResult<string> OnGet([FromBody] SIMALCIFDTS x)
        {


            return DLLCOde.GetCifDetails(x.MobileNo, x.idNumber, x.username, x.password, System.DateTime.Now.ToString("yyyy-MM-dd" + "T" + "HH:mm:ss"), x.ChannelName, x.CIFNumber,x.AdditionalRef);

        }
    }
}
