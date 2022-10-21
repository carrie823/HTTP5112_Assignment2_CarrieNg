using System;
using System.Reflection;

namespace HTTP5112_Assign2_CarrieNg.Areas.HelpPage.ModelDescriptions
{
    public interface IModelDocumentationProvider
    {
        string GetDocumentation(MemberInfo member);

        string GetDocumentation(Type type);
    }
}