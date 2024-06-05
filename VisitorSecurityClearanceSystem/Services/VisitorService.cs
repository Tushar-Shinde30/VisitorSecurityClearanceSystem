using Microsoft.AspNetCore.Http.HttpResults;
using VisitorSecurityClearanceSystem.CosmosDB;
using VisitorSecurityClearanceSystem.DTO;
using VisitorSecurityClearanceSystem.Interface;
using VisitorSecurityClearanceSystem.Model;

namespace VisitorSecurityClearanceSystem.Services
{
    public class VisitorService : IVisitorService
    {
        public readonly ICosmosDBService _cosmosDBService;

        public VisitorService(ICosmosDBService cosmosDBService)
        {
            _cosmosDBService = cosmosDBService;

        }

        public async Task<VisitorModel> AddVisitor(VisitorModel visitorModel)
        {
            //1. create obj of entity and mapp all the fields from model to entity
            VisitorEntity visitor = new VisitorEntity();
            visitor.Name = visitorModel.Name;
            visitor.Email = visitorModel.Email;
            visitor.PhoneNumber = visitorModel.PhoneNumber;

            //2. Assign values to madatory fields
            visitor.Id = Guid.NewGuid().ToString();
            visitor.UId = visitor.Id;
            visitor.DocumentType = "visitor";
            visitor.CreatedBy = "Tushar";
            visitor.CreatedOn = DateTime.Now;
            visitor.UpdatedBy = "";
            visitor.UpdatedOn = DateTime.Now;
            visitor.Version = 1;
            visitor.Active = true;
            visitor.Archived = false;

            var response = await _cosmosDBService.AddVisitor(visitor);  
            

            var responseModel = new VisitorModel();
            responseModel.UId = response.UId;
            responseModel.Name = response.Name;
            responseModel.Email = response.Email;
            responseModel.PhoneNumber = response.PhoneNumber;

            return responseModel;



        }
    }
}




