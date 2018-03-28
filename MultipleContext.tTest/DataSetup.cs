using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MultipleContext.Sales;
using Microsoft.EntityFrameworkCore;
using MultipleContext.Workflow;

namespace MultipleContext.tTest
{
    public static class DataSetup
    {
        public static SalesContext GetSalesContext()
        {
            var salesOptions = new DbContextOptionsBuilder<SalesContext>()
                              .UseInMemoryDatabase(Guid.NewGuid().ToString())
                              .Options;
            var salesContext = new SalesContext(salesOptions);
            AddItemsToSales(salesContext);

            return salesContext;
        }

        public static WorkflowContext GetWorkflowContext()
        {
            var workflowOptions = new DbContextOptionsBuilder<WorkflowContext>()
                              .UseInMemoryDatabase(Guid.NewGuid().ToString())
                              .Options;

            var workflowContext = new WorkflowContext(workflowOptions);

            AddItemsToWorkflow(workflowContext);
            return workflowContext;
        }

        public static void AddItemsToSales(SalesContext context)
        {
            context.Orders.Add(new Order { Id = 1, OrderDate = new DateTime(2018, 3, 1) });
            context.Orders.Add(new Order { Id = 2, OrderDate = new DateTime(2018, 3, 2) });
            context.OrderItems.Add(new OrderItem { Id = 1, OrderId = 1, ProductId = 1 });
            context.OrderItems.Add(new OrderItem { Id = 2, OrderId = 1, ProductId = 2 });
            context.SaveChanges();
        }

        public static void AddItemsToWorkflow(WorkflowContext context)
        {
            context.Flows.Add(new Flow { Id = 1, DocumentId = 1 });
            context.Flows.Add(new Flow { Id = 2, DocumentId = 2 });
            context.Documents.Add(new Document { Id = 1, Type = "Order", DocumentId = 1 });
            context.Documents.Add(new Document { Id = 2, Type = "Order", DocumentId = 2 });
            context.SaveChanges();
        }
    }
}
