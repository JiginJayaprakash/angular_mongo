using Microsoft.AspNetCore.Mvc;

namespace webapiproj.Controllers;

[ApiController]
[Route("[controller]")]
public class BinaryController : ControllerBase
{
    [HttpGet(Name = "GetBinary")]
    public string IfGood(string binaryString)
    {
            int onesCount = 0;
            int zerosCount = 0;

            foreach (char digit in binaryString)
            {
                if (digit == '1')
                {
                    onesCount++;
                }
                else if (digit == '0')
                {
                    zerosCount++;
                }
                if (onesCount < zerosCount)
                {
                    return "bad";
                }
            }
            return onesCount == zerosCount ? "good": "bad";
        }
}
