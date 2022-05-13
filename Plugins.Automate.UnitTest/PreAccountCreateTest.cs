namespace PPTemplateALMPlugins.UnitTest
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using System;
    using Microsoft.Xrm.Sdk;
    using Microsoft.Xrm.Sdk.Fakes;
    using System.Collections.Generic;
    using PPTemplate.ALM.PPTemplateALMPlugins;

    [TestClass]
    public class PreAccountCreateTest : UnitTestBase
    {
        [TestMethod]
        public void Test_SetNameField()
        {
            Entity entAccount = new Entity("account");
            entAccount["name"] = "No Hello World";

            PluginExecutionContext.InputParametersGet = () => new ParameterCollection
            {
                new KeyValuePair<string, object>("Target", entAccount)
            };
            PluginExecutionContext.DepthGet = () => 1;
            PluginExecutionContext.MessageNameGet = () => "create";
            PluginExecutionContext.InitiatingUserIdGet = () => Guid.NewGuid();


            PreOperationaccountCreate plugin = new PreOperationaccountCreate(string.Empty, string.Empty);
            plugin.Execute(this.ServiceProvider);
        }

        [TestMethod]
        public void Test_SetNameField_Error()
        {
            Entity entAccount = new Entity("account");
            entAccount["name"] = "No Hello World";

            PluginExecutionContext.InputParametersGet = () => new ParameterCollection
            {
                new KeyValuePair<string, object>("Target", entAccount)
            };
            PluginExecutionContext.DepthGet = () => 1;
            PluginExecutionContext.MessageNameGet = () => "create";
            PluginExecutionContext.InitiatingUserIdGet = () => Guid.NewGuid();

            PreOperationaccountCreate plugin = new PreOperationaccountCreate(string.Empty, string.Empty);
            plugin.Execute(this.ServiceProvider);
        }
    }
}
