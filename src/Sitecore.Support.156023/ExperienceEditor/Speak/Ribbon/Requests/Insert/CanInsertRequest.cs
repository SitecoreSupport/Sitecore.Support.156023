namespace Sitecore.Support.ExperienceEditor.Speak.Ribbon.Requests.Insert
{
    public class CanInsertRequest : Sitecore.ExperienceEditor.Speak.Ribbon.Requests.Insert.CanInsertRequest
    {
        public override bool GetControlState()
        {
            base.RequestContext.ValidateContextItem();
            return !(base.RequestContext.WebEditMode != "edit") && base.RequestContext.Item.Access.CanCreate() && base.RequestContext.Item.Access.CanWriteLanguage();
        }
    }
}