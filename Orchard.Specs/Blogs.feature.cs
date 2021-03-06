﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (http://www.specflow.org/).
//      SpecFlow Version:1.8.1.0
//      SpecFlow Generator Version:1.8.0.0
//      Runtime Version:4.0.30319.239
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace Orchard.Specs
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "1.8.1.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [NUnit.Framework.TestFixtureAttribute()]
    [NUnit.Framework.DescriptionAttribute("Blog")]
    public partial class BlogFeature
    {
        
        private static TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "Blogs.feature"
#line hidden
        
        [NUnit.Framework.TestFixtureSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Blog", "  In order to add blogs to my site\r\n  As an author\r\n  I want to create blogs and " +
                    "create, publish and edit blog posts", ProgrammingLanguage.CSharp, ((string[])(null)));
            testRunner.OnFeatureStart(featureInfo);
        }
        
        [NUnit.Framework.TestFixtureTearDownAttribute()]
        public virtual void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        [NUnit.Framework.SetUpAttribute()]
        public virtual void TestInitialize()
        {
        }
        
        [NUnit.Framework.TearDownAttribute()]
        public virtual void ScenarioTearDown()
        {
            testRunner.OnScenarioEnd();
        }
        
        public virtual void ScenarioSetup(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioStart(scenarioInfo);
        }
        
        public virtual void ScenarioCleanup()
        {
            testRunner.CollectScenarioErrors();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("In the admin (menu) there is a link to create a Blog")]
        public virtual void InTheAdminMenuThereIsALinkToCreateABlog()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("In the admin (menu) there is a link to create a Blog", ((string[])(null)));
#line 6
this.ScenarioSetup(scenarioInfo);
#line 7
    testRunner.Given("I have installed Orchard");
#line 8
    testRunner.When("I go to \"admin\"");
#line 9
    testRunner.Then("I should see \"<a[^>]*href=\"/Admin/Blogs/Create\"[^>]*>Blog</a>\"");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("I can create a new blog and blog post")]
        public virtual void ICanCreateANewBlogAndBlogPost()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("I can create a new blog and blog post", ((string[])(null)));
#line 11
this.ScenarioSetup(scenarioInfo);
#line 12
    testRunner.Given("I have installed Orchard");
#line 13
    testRunner.When("I go to \"admin/blogs/create\"");
#line hidden
            TechTalk.SpecFlow.Table table1 = new TechTalk.SpecFlow.Table(new string[] {
                        "name",
                        "value"});
            table1.AddRow(new string[] {
                        "Title.Title",
                        "My Blog"});
#line 14
        testRunner.And("I fill in", ((string)(null)), table1);
#line 17
        testRunner.And("I hit \"Save\"");
#line 18
        testRunner.And("I go to \"admin/blogs\"");
#line 19
        testRunner.And("I follow \"My Blog\"");
#line 20
        testRunner.And("I follow \"New Post\" where class name has \"primaryAction\"");
#line hidden
            TechTalk.SpecFlow.Table table2 = new TechTalk.SpecFlow.Table(new string[] {
                        "name",
                        "value"});
            table2.AddRow(new string[] {
                        "Title.Title",
                        "My Post"});
            table2.AddRow(new string[] {
                        "Body.Text",
                        "Hi there."});
#line 21
        testRunner.And("I fill in", ((string)(null)), table2);
#line 25
        testRunner.And("I hit \"Publish Now\"");
#line 26
        testRunner.And("I am redirected");
#line 27
    testRunner.Then("I should see \"Your Blog Post has been created.\"");
#line 28
    testRunner.When("I go to \"my-blog\"");
#line 29
    testRunner.Then("I should see \"<h1[^>]*>.*?My Blog.*?</h1>\"");
#line 30
        testRunner.And("I should see \"<h1[^>]*>.*?My Post.*?</h1>\"");
#line 31
    testRunner.When("I go to \"my-blog/my-post\"");
#line 32
    testRunner.Then("I should see \"<h1[^>]*>.*?My Post.*?</h1>\"");
#line 33
        testRunner.And("I should see \"Hi there.\"");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("I can create a new blog with multiple blog posts each with the same title and uni" +
            "que slugs are generated or given for said posts")]
        public virtual void ICanCreateANewBlogWithMultipleBlogPostsEachWithTheSameTitleAndUniqueSlugsAreGeneratedOrGivenForSaidPosts()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("I can create a new blog with multiple blog posts each with the same title and uni" +
                    "que slugs are generated or given for said posts", ((string[])(null)));
#line 35
this.ScenarioSetup(scenarioInfo);
#line 36
    testRunner.Given("I have installed Orchard");
#line 37
    testRunner.When("I go to \"admin/blogs/create\"");
#line hidden
            TechTalk.SpecFlow.Table table3 = new TechTalk.SpecFlow.Table(new string[] {
                        "name",
                        "value"});
            table3.AddRow(new string[] {
                        "Title.Title",
                        "My Blog"});
#line 38
        testRunner.And("I fill in", ((string)(null)), table3);
#line 41
        testRunner.And("I hit \"Save\"");
#line 42
        testRunner.And("I go to \"admin/blogs\"");
#line 43
        testRunner.And("I follow \"My Blog\"");
#line 44
        testRunner.And("I follow \"New Post\" where class name has \"primaryAction\"");
#line hidden
            TechTalk.SpecFlow.Table table4 = new TechTalk.SpecFlow.Table(new string[] {
                        "name",
                        "value"});
            table4.AddRow(new string[] {
                        "Title.Title",
                        "My Post"});
            table4.AddRow(new string[] {
                        "Body.Text",
                        "Hi there."});
#line 45
        testRunner.And("I fill in", ((string)(null)), table4);
#line 49
        testRunner.And("I hit \"Publish Now\"");
#line 50
        testRunner.And("I go to \"my-blog/my-post\"");
#line 51
    testRunner.Then("I should see \"<h1[^>]*>.*?My Post.*?</h1>\"");
#line 52
        testRunner.And("I should see \"Hi there.\"");
#line 53
    testRunner.When("I go to \"admin/blogs\"");
#line 54
        testRunner.And("I follow \"My Blog\"");
#line 55
        testRunner.And("I follow \"New Post\" where class name has \"primaryAction\"");
#line hidden
            TechTalk.SpecFlow.Table table5 = new TechTalk.SpecFlow.Table(new string[] {
                        "name",
                        "value"});
            table5.AddRow(new string[] {
                        "Title.Title",
                        "My Post"});
            table5.AddRow(new string[] {
                        "Body.Text",
                        "Hi there, again."});
#line 56
        testRunner.And("I fill in", ((string)(null)), table5);
#line 60
        testRunner.And("I hit \"Publish Now\"");
#line 61
        testRunner.And("I go to \"my-blog/my-post-2\"");
#line 62
    testRunner.Then("I should see \"<h1[^>]*>.*?My Post.*?</h1>\"");
#line 63
        testRunner.And("I should see \"Hi there, again.\"");
#line 64
    testRunner.When("I go to \"admin/blogs\"");
#line 65
        testRunner.And("I follow \"My Blog\"");
#line 66
        testRunner.And("I follow \"New Post\" where class name has \"primaryAction\"");
#line hidden
            TechTalk.SpecFlow.Table table6 = new TechTalk.SpecFlow.Table(new string[] {
                        "name",
                        "value"});
            table6.AddRow(new string[] {
                        "Title.Title",
                        "My Post"});
            table6.AddRow(new string[] {
                        "Autoroute.CurrentUrl",
                        "my-blog/my-post"});
            table6.AddRow(new string[] {
                        "Body.Text",
                        "Are you still there?"});
#line 67
        testRunner.And("I fill in", ((string)(null)), table6);
#line 72
        testRunner.And("I hit \"Publish Now\"");
#line 73
        testRunner.And("I go to \"my-blog/my-post-3\"");
#line 74
    testRunner.Then("I should see \"<h1[^>]*>.*?My Post.*?</h1>\"");
#line 75
        testRunner.And("I should see \"Are you still there?\"");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("When viewing a blog the user agent is given an RSS feed of the blog\'s posts")]
        public virtual void WhenViewingABlogTheUserAgentIsGivenAnRSSFeedOfTheBlogSPosts()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("When viewing a blog the user agent is given an RSS feed of the blog\'s posts", ((string[])(null)));
#line 77
this.ScenarioSetup(scenarioInfo);
#line 78
    testRunner.Given("I have installed Orchard");
#line 79
    testRunner.When("I go to \"admin/blogs/create\"");
#line hidden
            TechTalk.SpecFlow.Table table7 = new TechTalk.SpecFlow.Table(new string[] {
                        "name",
                        "value"});
            table7.AddRow(new string[] {
                        "Title.Title",
                        "My Blog"});
#line 80
        testRunner.And("I fill in", ((string)(null)), table7);
#line 83
        testRunner.And("I hit \"Save\"");
#line 84
        testRunner.And("I go to \"admin/blogs\"");
#line 85
        testRunner.And("I follow \"My Blog\"");
#line 86
        testRunner.And("I follow \"New Post\" where class name has \"primaryAction\"");
#line hidden
            TechTalk.SpecFlow.Table table8 = new TechTalk.SpecFlow.Table(new string[] {
                        "name",
                        "value"});
            table8.AddRow(new string[] {
                        "Title.Title",
                        "My Post"});
            table8.AddRow(new string[] {
                        "Body.Text",
                        "Hi there."});
#line 87
        testRunner.And("I fill in", ((string)(null)), table8);
#line 91
        testRunner.And("I hit \"Publish Now\"");
#line 92
        testRunner.And("I am redirected");
#line 93
        testRunner.And("I go to \"my-blog/my-post\"");
#line 94
    testRunner.Then("I should see \"<link rel=\"alternate\" type=\"application/rss\\+xml\" title=\"My Blog\" h" +
                    "ref=\"/rss\\?containerid=\\d+\" />\"");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Enabling remote blog publishing inserts the appropriate metaweblogapi markup into" +
            " the blog\'s page")]
        public virtual void EnablingRemoteBlogPublishingInsertsTheAppropriateMetaweblogapiMarkupIntoTheBlogSPage()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Enabling remote blog publishing inserts the appropriate metaweblogapi markup into" +
                    " the blog\'s page", ((string[])(null)));
#line 96
this.ScenarioSetup(scenarioInfo);
#line 97
    testRunner.Given("I have installed Orchard");
#line 98
        testRunner.And("I have enabled \"XmlRpc\"");
#line 99
        testRunner.And("I have enabled \"Orchard.Blogs.RemotePublishing\"");
#line 100
    testRunner.When("I go to \"admin/blogs/create\"");
#line hidden
            TechTalk.SpecFlow.Table table9 = new TechTalk.SpecFlow.Table(new string[] {
                        "name",
                        "value"});
            table9.AddRow(new string[] {
                        "Title.Title",
                        "My Blog"});
#line 101
        testRunner.And("I fill in", ((string)(null)), table9);
#line 104
        testRunner.And("I hit \"Save\"");
#line 105
        testRunner.And("I go to \"my-blog\"");
#line 106
    testRunner.Then("I should see \"<link href=\"[^\"]*/XmlRpc/LiveWriter/Manifest\" rel=\"wlwmanifest\" typ" +
                    "e=\"application/wlwmanifest\\+xml\" />\"");
#line 107
    testRunner.When("I go to \"/XmlRpc/LiveWriter/Manifest\"");
#line 108
    testRunner.Then("the content type should be \"\\btext/xml\\b\"");
#line 109
        testRunner.And("I should see \"<manifest xmlns=\"http\\://schemas\\.microsoft\\.com/wlw/manifest/weblo" +
                    "g\">\"");
#line 110
        testRunner.And("I should see \"<clientType>Metaweblog</clientType>\"");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("The virtual path of my installation when not at the root is reflected in the URL " +
            "example for the slug field when creating a blog or blog post")]
        public virtual void TheVirtualPathOfMyInstallationWhenNotAtTheRootIsReflectedInTheURLExampleForTheSlugFieldWhenCreatingABlogOrBlogPost()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("The virtual path of my installation when not at the root is reflected in the URL " +
                    "example for the slug field when creating a blog or blog post", ((string[])(null)));
#line 112
this.ScenarioSetup(scenarioInfo);
#line 113
    testRunner.Given("I have installed Orchard at \"/OrchardLocal\"");
#line 114
    testRunner.When("I go to \"admin/blogs/create\"");
#line 115
    testRunner.Then("I should see \"<span>http\\://localhost/OrchardLocal/</span>\"");
#line hidden
            TechTalk.SpecFlow.Table table10 = new TechTalk.SpecFlow.Table(new string[] {
                        "name",
                        "value"});
            table10.AddRow(new string[] {
                        "Title.Title",
                        "My Blog"});
#line 116
    testRunner.When("I fill in", ((string)(null)), table10);
#line 119
        testRunner.And("I hit \"Save\"");
#line 120
        testRunner.And("I go to \"admin/blogs\"");
#line 121
        testRunner.And("I follow \"My Blog\"");
#line 122
        testRunner.And("I follow \"New Post\" where class name has \"primaryAction\"");
#line 123
    testRunner.Then("I should see \"<span>http\\://localhost/OrchardLocal/</span>\"");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("The virtual path of my installation when at the root is reflected in the URL exam" +
            "ple for the slug field when creating a blog or blog post")]
        public virtual void TheVirtualPathOfMyInstallationWhenAtTheRootIsReflectedInTheURLExampleForTheSlugFieldWhenCreatingABlogOrBlogPost()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("The virtual path of my installation when at the root is reflected in the URL exam" +
                    "ple for the slug field when creating a blog or blog post", ((string[])(null)));
#line 125
this.ScenarioSetup(scenarioInfo);
#line 126
    testRunner.Given("I have installed Orchard at \"/\"");
#line 127
    testRunner.When("I go to \"admin/blogs/create\"");
#line 128
    testRunner.Then("I should see \"<span>http\\://localhost/</span>\"");
#line hidden
            TechTalk.SpecFlow.Table table11 = new TechTalk.SpecFlow.Table(new string[] {
                        "name",
                        "value"});
            table11.AddRow(new string[] {
                        "Title.Title",
                        "My Blog"});
#line 129
    testRunner.When("I fill in", ((string)(null)), table11);
#line 132
        testRunner.And("I hit \"Save\"");
#line 133
        testRunner.And("I go to \"admin/blogs\"");
#line 134
        testRunner.And("I follow \"My Blog\"");
#line 135
        testRunner.And("I follow \"New Post\" where class name has \"primaryAction\"");
#line 136
    testRunner.Then("I should see \"<span>http\\://localhost/</span>\"");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("I set my blog to be the content for the home page and the posts for the blog be r" +
            "ooted to the app")]
        public virtual void ISetMyBlogToBeTheContentForTheHomePageAndThePostsForTheBlogBeRootedToTheApp()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("I set my blog to be the content for the home page and the posts for the blog be r" +
                    "ooted to the app", ((string[])(null)));
#line 138
this.ScenarioSetup(scenarioInfo);
#line 139
    testRunner.Given("I have installed Orchard");
#line 140
    testRunner.When("I go to \"admin/blogs/create\"");
#line hidden
            TechTalk.SpecFlow.Table table12 = new TechTalk.SpecFlow.Table(new string[] {
                        "name",
                        "value"});
            table12.AddRow(new string[] {
                        "Title.Title",
                        "My Blog"});
            table12.AddRow(new string[] {
                        "Autoroute.PromoteToHomePage",
                        "true"});
#line 141
        testRunner.And("I fill in", ((string)(null)), table12);
#line 145
        testRunner.And("I hit \"Save\"");
#line 146
        testRunner.And("I go to \"admin/blogs\"");
#line 147
        testRunner.And("I follow \"My Blog\"");
#line 148
        testRunner.And("I follow \"New Post\" where class name has \"primaryAction\"");
#line hidden
            TechTalk.SpecFlow.Table table13 = new TechTalk.SpecFlow.Table(new string[] {
                        "name",
                        "value"});
            table13.AddRow(new string[] {
                        "Title.Title",
                        "My Post"});
            table13.AddRow(new string[] {
                        "Body.Text",
                        "Hi there."});
#line 149
        testRunner.And("I fill in", ((string)(null)), table13);
#line 153
        testRunner.And("I hit \"Publish Now\"");
#line 154
        testRunner.And("I am redirected");
#line 155
        testRunner.And("I go to \"/\"");
#line 156
    testRunner.Then("I should see \"<h1>My Blog</h1>\"");
#line 157
    testRunner.When("I go to \"/my-blog\"");
#line 158
    testRunner.Then("the status should be 404 \"Not Found\"");
#line 159
    testRunner.When("I go to \"/my-post\"");
#line 160
    testRunner.Then("I should see \"<h1>My Post</h1>\"");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("I can create browse blog posts on several pages")]
        public virtual void ICanCreateBrowseBlogPostsOnSeveralPages()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("I can create browse blog posts on several pages", ((string[])(null)));
#line 162
this.ScenarioSetup(scenarioInfo);
#line 163
    testRunner.Given("I have installed Orchard");
#line 164
    testRunner.When("I go to \"admin/blogs/create\"");
#line hidden
            TechTalk.SpecFlow.Table table14 = new TechTalk.SpecFlow.Table(new string[] {
                        "name",
                        "value"});
            table14.AddRow(new string[] {
                        "Title.Title",
                        "My Blog"});
#line 165
        testRunner.And("I fill in", ((string)(null)), table14);
#line 168
        testRunner.And("I hit \"Save\"");
#line 169
        testRunner.And("I go to \"admin/blogs\"");
#line 170
        testRunner.And("I follow \"My Blog\"");
#line 171
        testRunner.And("I follow \"New Post\" where class name has \"primaryAction\"");
#line hidden
            TechTalk.SpecFlow.Table table15 = new TechTalk.SpecFlow.Table(new string[] {
                        "name",
                        "value"});
            table15.AddRow(new string[] {
                        "Title.Title",
                        "My Post 1"});
#line 172
        testRunner.And("I fill in", ((string)(null)), table15);
#line 175
        testRunner.And("I hit \"Publish Now\"");
#line 176
        testRunner.And("I am redirected");
#line 177
        testRunner.And("I go to \"admin/blogs\"");
#line 178
        testRunner.And("I follow \"My Blog\"");
#line 179
        testRunner.And("I follow \"New Post\" where class name has \"primaryAction\"");
#line hidden
            TechTalk.SpecFlow.Table table16 = new TechTalk.SpecFlow.Table(new string[] {
                        "name",
                        "value"});
            table16.AddRow(new string[] {
                        "Title.Title",
                        "My Post 2"});
#line 180
        testRunner.And("I fill in", ((string)(null)), table16);
#line 183
        testRunner.And("I hit \"Publish Now\"");
#line 184
        testRunner.And("I am redirected");
#line 185
        testRunner.And("I go to \"admin/blogs\"");
#line 186
        testRunner.And("I follow \"My Blog\"");
#line 187
        testRunner.And("I follow \"New Post\" where class name has \"primaryAction\"");
#line hidden
            TechTalk.SpecFlow.Table table17 = new TechTalk.SpecFlow.Table(new string[] {
                        "name",
                        "value"});
            table17.AddRow(new string[] {
                        "Title.Title",
                        "My Post 3"});
#line 188
        testRunner.And("I fill in", ((string)(null)), table17);
#line 191
        testRunner.And("I hit \"Publish Now\"");
#line 192
        testRunner.And("I am redirected");
#line 193
        testRunner.And("I go to \"admin/blogs\"");
#line 194
        testRunner.And("I follow \"My Blog\"");
#line 195
        testRunner.And("I follow \"New Post\" where class name has \"primaryAction\"");
#line hidden
            TechTalk.SpecFlow.Table table18 = new TechTalk.SpecFlow.Table(new string[] {
                        "name",
                        "value"});
            table18.AddRow(new string[] {
                        "Title.Title",
                        "My Post 4"});
#line 196
        testRunner.And("I fill in", ((string)(null)), table18);
#line 199
        testRunner.And("I hit \"Publish Now\"");
#line 200
        testRunner.And("I am redirected");
#line 201
        testRunner.And("I go to \"admin/blogs\"");
#line 202
        testRunner.And("I follow \"My Blog\"");
#line 203
        testRunner.And("I follow \"New Post\" where class name has \"primaryAction\"");
#line hidden
            TechTalk.SpecFlow.Table table19 = new TechTalk.SpecFlow.Table(new string[] {
                        "name",
                        "value"});
            table19.AddRow(new string[] {
                        "Title.Title",
                        "My Post 5"});
#line 204
        testRunner.And("I fill in", ((string)(null)), table19);
#line 207
        testRunner.And("I hit \"Publish Now\"");
#line 208
        testRunner.And("I am redirected");
#line 209
        testRunner.And("I go to \"admin/blogs\"");
#line 210
        testRunner.And("I follow \"My Blog\"");
#line 211
        testRunner.And("I follow \"New Post\" where class name has \"primaryAction\"");
#line hidden
            TechTalk.SpecFlow.Table table20 = new TechTalk.SpecFlow.Table(new string[] {
                        "name",
                        "value"});
            table20.AddRow(new string[] {
                        "Title.Title",
                        "My Post 6"});
#line 212
        testRunner.And("I fill in", ((string)(null)), table20);
#line 215
        testRunner.And("I hit \"Publish Now\"");
#line 216
        testRunner.And("I am redirected");
#line 217
        testRunner.And("I go to \"admin/blogs\"");
#line 218
        testRunner.And("I follow \"My Blog\"");
#line 219
        testRunner.And("I follow \"New Post\" where class name has \"primaryAction\"");
#line hidden
            TechTalk.SpecFlow.Table table21 = new TechTalk.SpecFlow.Table(new string[] {
                        "name",
                        "value"});
            table21.AddRow(new string[] {
                        "Title.Title",
                        "My Post 7"});
#line 220
        testRunner.And("I fill in", ((string)(null)), table21);
#line 223
        testRunner.And("I hit \"Publish Now\"");
#line 224
        testRunner.And("I am redirected");
#line 225
        testRunner.And("I go to \"admin/blogs\"");
#line 226
        testRunner.And("I follow \"My Blog\"");
#line 227
        testRunner.And("I follow \"New Post\" where class name has \"primaryAction\"");
#line hidden
            TechTalk.SpecFlow.Table table22 = new TechTalk.SpecFlow.Table(new string[] {
                        "name",
                        "value"});
            table22.AddRow(new string[] {
                        "Title.Title",
                        "My Post 8"});
#line 228
        testRunner.And("I fill in", ((string)(null)), table22);
#line 231
        testRunner.And("I hit \"Publish Now\"");
#line 232
        testRunner.And("I am redirected");
#line 233
        testRunner.And("I go to \"admin/blogs\"");
#line 234
        testRunner.And("I follow \"My Blog\"");
#line 235
        testRunner.And("I follow \"New Post\" where class name has \"primaryAction\"");
#line hidden
            TechTalk.SpecFlow.Table table23 = new TechTalk.SpecFlow.Table(new string[] {
                        "name",
                        "value"});
            table23.AddRow(new string[] {
                        "Title.Title",
                        "My Post 9"});
#line 236
        testRunner.And("I fill in", ((string)(null)), table23);
#line 239
        testRunner.And("I hit \"Publish Now\"");
#line 240
        testRunner.And("I am redirected");
#line 241
        testRunner.And("I go to \"admin/blogs\"");
#line 242
        testRunner.And("I follow \"My Blog\"");
#line 243
        testRunner.And("I follow \"New Post\" where class name has \"primaryAction\"");
#line hidden
            TechTalk.SpecFlow.Table table24 = new TechTalk.SpecFlow.Table(new string[] {
                        "name",
                        "value"});
            table24.AddRow(new string[] {
                        "Title.Title",
                        "My Post 10"});
#line 244
        testRunner.And("I fill in", ((string)(null)), table24);
#line 247
        testRunner.And("I hit \"Publish Now\"");
#line 248
        testRunner.And("I am redirected");
#line 249
        testRunner.And("I go to \"admin/blogs\"");
#line 250
        testRunner.And("I follow \"My Blog\"");
#line 251
        testRunner.And("I follow \"New Post\" where class name has \"primaryAction\"");
#line hidden
            TechTalk.SpecFlow.Table table25 = new TechTalk.SpecFlow.Table(new string[] {
                        "name",
                        "value"});
            table25.AddRow(new string[] {
                        "Title.Title",
                        "My Post 11"});
#line 252
        testRunner.And("I fill in", ((string)(null)), table25);
#line 255
        testRunner.And("I hit \"Publish Now\"");
#line 256
        testRunner.And("I am redirected");
#line 257
        testRunner.And("I go to \"admin/blogs\"");
#line 258
        testRunner.And("I follow \"My Blog\"");
#line 259
        testRunner.And("I follow \"New Post\" where class name has \"primaryAction\"");
#line hidden
            TechTalk.SpecFlow.Table table26 = new TechTalk.SpecFlow.Table(new string[] {
                        "name",
                        "value"});
            table26.AddRow(new string[] {
                        "Title.Title",
                        "My Post 12"});
#line 260
        testRunner.And("I fill in", ((string)(null)), table26);
#line 263
        testRunner.And("I hit \"Publish Now\"");
#line 264
        testRunner.And("I am redirected");
#line 265
    testRunner.Then("I should see \"Your Blog Post has been created.\"");
#line 266
    testRunner.When("I go to \"my-blog\"");
#line 267
    testRunner.Then("I should see \"<h1[^>]*>.*?My Blog.*?</h1>\"");
#line 268
        testRunner.And("I should see \"<h1[^>]*>.*?My Post 12.*?</h1>\"");
#line 269
        testRunner.And("I should see \"<h1[^>]*>.*?My Post 11.*?</h1>\"");
#line 270
        testRunner.And("I should not see \"<h1[^>]*>.*?My Post 10.*?</h1>\"");
#line 271
    testRunner.When("I go to \"my-blog?page=2\"");
#line 272
    testRunner.Then("I should see \"<h1[^>]*>.*?My Blog.*?</h1>\"");
#line 273
        testRunner.And("I should see \"<h1[^>]*>.*?My Post 1.*?</h1>\"");
#line 274
        testRunner.And("I should see \"<h1[^>]*>.*?My Post 2.*?</h1>\"");
#line 275
        testRunner.And("I should not see \"<h1[^>]*>.*?My Post 3.*?</h1>\"");
#line hidden
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion
