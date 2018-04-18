using System;
using System.Linq;
using Xunit;

namespace MultipleContext.tTest
{
    public class MultipleContextQuery
    {
        [Fact]
        public void Test_Get_Data()
        {
            var salesContext = DataSetup.GetSalesContext();

            Assert.Equal(2, salesContext.Orders.Count());
        }

        [Fact]
        public void Test_Get_Workflow_Data()
        {
            var context = DataSetup.GetWorkflowContext();

            Assert.Equal(2, context.Flows.Count());
        }

        [Fact]
        public void Test_Get_Address_Data()
        {
            var salesContext = DataSetup.GetSalesContext();
            var order = salesContext.Orders.FirstOrDefault(p => p.Id == 2);
            Assert.Equal("1", order.Address.Street);
        }
    }
}
