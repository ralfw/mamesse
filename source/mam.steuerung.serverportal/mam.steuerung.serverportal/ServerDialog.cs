using Nancy;

namespace mam.steuerung.serverportal
{
    public class ServerDialog : NancyModule
    {
        public ServerDialog()
        {
            Get["/reset"] = _ => { ServerPortal.Instance.Feuern("Reset"); return HttpStatusCode.OK; };
            Get["/error"] = _ => { ServerPortal.Instance.Feuern("Error"); return HttpStatusCode.OK; };
            Get["/repair"] = _ => { ServerPortal.Instance.Feuern("Repair"); return HttpStatusCode.OK; };
            Get["/helpunderway"] = _ => { ServerPortal.Instance.Feuern("Helpunderway"); return HttpStatusCode.OK; };
        }
    }
}