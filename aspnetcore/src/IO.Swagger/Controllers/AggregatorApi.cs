/*
 * NyoStore
 *
 * This is a NyoStore server. Here you can find  out all the rest api's. 
 *
 * OpenAPI spec version: 1.0.0-oas3
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */
using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;
using Swashbuckle.AspNetCore.SwaggerGen;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using IO.Swagger.Attributes;
using IO.Swagger.Security;
using Microsoft.AspNetCore.Authorization;
using IO.Swagger.Models;

namespace IO.Swagger.Controllers
{ 
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    public class AggregatorApiController : ControllerBase
    { 
        /// <summary>
        /// Get store data
        /// </summary>
        /// <param name="storeKey">Store id of store to return</param>
        /// <response code="200">successful operation</response>
        /// <response code="400">Bad request</response>
        /// <response code="401">Unauthorized</response>
        /// <response code="403">Forbidden</response>
        /// <response code="404">Not Found</response>
        /// <response code="405">Invalid input</response>
        /// <response code="409">Conflict</response>
        /// <response code="5XX">Unexpected Error</response>
        [HttpGet]
        [Route("/VinaySavner23/Nyo_Store/1.0.0-oas3/store/{store_key}")]
        [Authorize(AuthenticationSchemes = BearerAuthenticationHandler.SchemeName)]
        [ValidateModelState]
        [SwaggerOperation("GetAggregatorStore")]
        [SwaggerResponse(statusCode: 200, type: typeof(AggregatorStoreData), description: "successful operation")]
        [SwaggerResponse(statusCode: 400, type: typeof(Error), description: "Bad request")]
        [SwaggerResponse(statusCode: 401, type: typeof(Unauthorized), description: "Unauthorized")]
        [SwaggerResponse(statusCode: 403, type: typeof(Forbidden), description: "Forbidden")]
        [SwaggerResponse(statusCode: 404, type: typeof(Error), description: "Not Found")]
        [SwaggerResponse(statusCode: 405, type: typeof(Error), description: "Invalid input")]
        [SwaggerResponse(statusCode: 409, type: typeof(Error), description: "Conflict")]
        [SwaggerResponse(statusCode: 5XX, type: typeof(Error), description: "Unexpected Error")]
        public virtual IActionResult GetAggregatorStore([FromRoute][Required]string storeKey)
        { 
            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200, default(AggregatorStoreData));

            //TODO: Uncomment the next line to return response 400 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(400, default(Error));

            //TODO: Uncomment the next line to return response 401 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(401, default(Unauthorized));

            //TODO: Uncomment the next line to return response 403 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(403, default(Forbidden));

            //TODO: Uncomment the next line to return response 404 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(404, default(Error));

            //TODO: Uncomment the next line to return response 405 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(405, default(Error));

            //TODO: Uncomment the next line to return response 409 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(409, default(Error));

            //TODO: Uncomment the next line to return response 5XX or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(5XX, default(Error));
            string exampleJson = null;
            exampleJson = "{\n  \"data\" : {\n    \"store_id\" : \"store_id\",\n    \"website\" : \"website\",\n    \"address\" : {\n      \"zipcode\" : \"zipcode\",\n      \"country\" : \"country\",\n      \"deleted\" : false,\n      \"addr2\" : \"addr2\",\n      \"address_type\" : \"store\",\n      \"addr1\" : \"addr1\",\n      \"city\" : \"city\",\n      \"geog\" : {\n        \"crs\" : {\n          \"type\" : \"type\",\n          \"properties\" : {\n            \"name\" : \"name\"\n          }\n        },\n        \"coordinates\" : [ 0.8008281904610115, 0.8008281904610115 ],\n        \"type\" : \"type\"\n      },\n      \"contact\" : {\n        \"contact_person\" : \"contact_person\",\n        \"phone\" : \"phone\",\n        \"contact_id\" : \"contact_id\",\n        \"email\" : \"email\"\n      },\n      \"address_id\" : \"address_id\",\n      \"state\" : \"state\"\n    },\n    \"documents\" : [ \"documents\", \"documents\" ],\n    \"registration_number\" : \"registration_number\",\n    \"name\" : \"name\",\n    \"logo\" : \"logo\",\n    \"industry\" : \"industry\",\n    \"slogan\" : \"slogan\",\n    \"tax_id\" : \"tax_id\"\n  },\n  \"message\" : \"message\",\n  \"status\" : true\n}";
            
                        var example = exampleJson != null
                        ? JsonConvert.DeserializeObject<AggregatorStoreData>(exampleJson)
                        : default(AggregatorStoreData);            //TODO: Change the data returned
            return new ObjectResult(example);
        }

        /// <summary>
        /// Get store data
        /// </summary>
        /// <param name="storeKey">Store id of store to return</param>
        /// <param name="branchKey">Branch id of branch to return</param>
        /// <response code="200">successful operation</response>
        /// <response code="400">Bad request</response>
        /// <response code="401">Unauthorized</response>
        /// <response code="403">Forbidden</response>
        /// <response code="404">Not Found</response>
        /// <response code="405">Invalid input</response>
        /// <response code="409">Conflict</response>
        /// <response code="5XX">Unexpected Error</response>
        [HttpGet]
        [Route("/VinaySavner23/Nyo_Store/1.0.0-oas3/store/{store_key}/branch/{branch_key}")]
        [Authorize(AuthenticationSchemes = BearerAuthenticationHandler.SchemeName)]
        [ValidateModelState]
        [SwaggerOperation("GetAggregatorStoreBranch")]
        [SwaggerResponse(statusCode: 200, type: typeof(AggregatorStoreBranchData), description: "successful operation")]
        [SwaggerResponse(statusCode: 400, type: typeof(Error), description: "Bad request")]
        [SwaggerResponse(statusCode: 401, type: typeof(Unauthorized), description: "Unauthorized")]
        [SwaggerResponse(statusCode: 403, type: typeof(Forbidden), description: "Forbidden")]
        [SwaggerResponse(statusCode: 404, type: typeof(Error), description: "Not Found")]
        [SwaggerResponse(statusCode: 405, type: typeof(Error), description: "Invalid input")]
        [SwaggerResponse(statusCode: 409, type: typeof(Error), description: "Conflict")]
        [SwaggerResponse(statusCode: 5XX, type: typeof(Error), description: "Unexpected Error")]
        public virtual IActionResult GetAggregatorStoreBranch([FromRoute][Required]string storeKey, [FromRoute][Required]string branchKey)
        { 
            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200, default(AggregatorStoreBranchData));

            //TODO: Uncomment the next line to return response 400 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(400, default(Error));

            //TODO: Uncomment the next line to return response 401 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(401, default(Unauthorized));

            //TODO: Uncomment the next line to return response 403 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(403, default(Forbidden));

            //TODO: Uncomment the next line to return response 404 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(404, default(Error));

            //TODO: Uncomment the next line to return response 405 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(405, default(Error));

            //TODO: Uncomment the next line to return response 409 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(409, default(Error));

            //TODO: Uncomment the next line to return response 5XX or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(5XX, default(Error));
            string exampleJson = null;
            exampleJson = "{\n  \"data\" : {\n    \"schedule\" : {\n      \"policy_id\" : \"policy_id\",\n      \"timezone\" : \"timezone\",\n      \"name\" : \"name\",\n      \"schedule_id\" : \"schedule_id\",\n      \"timeslots\" : \"timeslots\"\n    },\n    \"address\" : {\n      \"zipcode\" : \"zipcode\",\n      \"country\" : \"country\",\n      \"deleted\" : false,\n      \"addr2\" : \"addr2\",\n      \"address_type\" : \"store\",\n      \"addr1\" : \"addr1\",\n      \"city\" : \"city\",\n      \"geog\" : {\n        \"crs\" : {\n          \"type\" : \"type\",\n          \"properties\" : {\n            \"name\" : \"name\"\n          }\n        },\n        \"coordinates\" : [ 0.8008281904610115, 0.8008281904610115 ],\n        \"type\" : \"type\"\n      },\n      \"contact\" : {\n        \"contact_person\" : \"contact_person\",\n        \"phone\" : \"phone\",\n        \"contact_id\" : \"contact_id\",\n        \"email\" : \"email\"\n      },\n      \"address_id\" : \"address_id\",\n      \"state\" : \"state\"\n    },\n    \"branch_id_custom\" : \"branch_id_custom\",\n    \"branch_id\" : \"branch_id\",\n    \"name\" : \"name\",\n    \"status\" : \"status\"\n  },\n  \"message\" : \"message\",\n  \"status\" : true\n}";
            
                        var example = exampleJson != null
                        ? JsonConvert.DeserializeObject<AggregatorStoreBranchData>(exampleJson)
                        : default(AggregatorStoreBranchData);            //TODO: Change the data returned
            return new ObjectResult(example);
        }

        /// <summary>
        /// Get nearby branches
        /// </summary>
        /// <param name="latitude">Latitude of address to return</param>
        /// <param name="longitude">Longitude of address to return</param>
        /// <param name="radius">Radius of address to return</param>
        /// <param name="maxrecords">maxrecords of address to return</param>
        /// <response code="200">successful operation</response>
        /// <response code="400">Bad request</response>
        /// <response code="401">Unauthorized</response>
        /// <response code="403">Forbidden</response>
        /// <response code="404">Not Found</response>
        /// <response code="405">Invalid input</response>
        /// <response code="409">Conflict</response>
        /// <response code="5XX">Unexpected Error</response>
        [HttpGet]
        [Route("/VinaySavner23/Nyo_Store/1.0.0-oas3/nearby-branches")]
        [Authorize(AuthenticationSchemes = BearerAuthenticationHandler.SchemeName)]
        [ValidateModelState]
        [SwaggerOperation("GetNearByBranches")]
        [SwaggerResponse(statusCode: 200, type: typeof(NearbyBranches), description: "successful operation")]
        [SwaggerResponse(statusCode: 400, type: typeof(Error), description: "Bad request")]
        [SwaggerResponse(statusCode: 401, type: typeof(Unauthorized), description: "Unauthorized")]
        [SwaggerResponse(statusCode: 403, type: typeof(Forbidden), description: "Forbidden")]
        [SwaggerResponse(statusCode: 404, type: typeof(Error), description: "Not Found")]
        [SwaggerResponse(statusCode: 405, type: typeof(Error), description: "Invalid input")]
        [SwaggerResponse(statusCode: 409, type: typeof(Error), description: "Conflict")]
        [SwaggerResponse(statusCode: 5XX, type: typeof(Error), description: "Unexpected Error")]
        public virtual IActionResult GetNearByBranches([FromQuery][Required()]string latitude, [FromQuery][Required()]string longitude, [FromQuery][Required()]int? radius, [FromQuery][Required()]int? maxrecords)
        { 
            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200, default(NearbyBranches));

            //TODO: Uncomment the next line to return response 400 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(400, default(Error));

            //TODO: Uncomment the next line to return response 401 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(401, default(Unauthorized));

            //TODO: Uncomment the next line to return response 403 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(403, default(Forbidden));

            //TODO: Uncomment the next line to return response 404 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(404, default(Error));

            //TODO: Uncomment the next line to return response 405 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(405, default(Error));

            //TODO: Uncomment the next line to return response 409 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(409, default(Error));

            //TODO: Uncomment the next line to return response 5XX or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(5XX, default(Error));
            string exampleJson = null;
            exampleJson = "{\n  \"data\" : [ {\n    \"distance\" : 0.8008281904610115,\n    \"branch_id\" : \"branch_id\",\n    \"address_id\" : \"address_id\",\n    \"name\" : \"name\",\n    \"schedule_id\" : \"schedule_id\",\n    \"disbranch_id_customtance\" : \"disbranch_id_customtance\",\n    \"status\" : \"status\"\n  }, {\n    \"distance\" : 0.8008281904610115,\n    \"branch_id\" : \"branch_id\",\n    \"address_id\" : \"address_id\",\n    \"name\" : \"name\",\n    \"schedule_id\" : \"schedule_id\",\n    \"disbranch_id_customtance\" : \"disbranch_id_customtance\",\n    \"status\" : \"status\"\n  } ],\n  \"message\" : \"message\",\n  \"status\" : true\n}";
            
                        var example = exampleJson != null
                        ? JsonConvert.DeserializeObject<NearbyBranches>(exampleJson)
                        : default(NearbyBranches);            //TODO: Change the data returned
            return new ObjectResult(example);
        }
    }
}
