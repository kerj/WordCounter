#pragma checksum "D:\Users\TheKerj\desktop\epicodus19\WordCounter.Solution\WordCounter\Views\WordCounter\New.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d6bd54e9afc603e96f006a89781daddc0425defd"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_WordCounter_New), @"mvc.1.0.view", @"/Views/WordCounter/New.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/WordCounter/New.cshtml", typeof(AspNetCore.Views_WordCounter_New))]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d6bd54e9afc603e96f006a89781daddc0425defd", @"/Views/WordCounter/New.cshtml")]
    public class Views_WordCounter_New : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 380, true);
            WriteLiteral(@"<h1>Add A word and a phrase to search</h1>

<form action=""/WordCounter"" method=""post"">
  <label for=""searchTerm"">Word to Search for</label>
  <input id=""searchTerm"" name=""searchTerm"" type=""text"">
  <label for=""phraseToSearch"">Phrase to look through for</label>
  <input id=""phraseToSearch"" name=""phraseToSearch"" type=""text"">
  <button type=""submit"">Add</buttton>
</form>
");
            EndContext();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
