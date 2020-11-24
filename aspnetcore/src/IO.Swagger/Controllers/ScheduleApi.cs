/*
 * NyoStore
 *
 * This is a NyoStore server. Here you can find  out all the rest api's. 
 *
 * OpenAPI spec version: 2.1
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
    public class ScheduleApiController : ControllerBase
    { 
        /// <summary>
        /// Add schedule
        /// </summary>
        /// <remarks>Add a schedule</remarks>
        /// <param name="storeId">Store id of store to return</param>
        /// <param name="body"></param>
        /// <response code="200">successful operation</response>
        /// <response code="400">Bad request</response>
        /// <response code="401">Unauthorized</response>
        /// <response code="403">Forbidden</response>
        /// <response code="404">Not Found</response>
        /// <response code="405">Invalid input</response>
        /// <response code="409">Conflict</response>
        /// <response code="5XX">Unexpected Error</response>
        [HttpPost]
        [Route("/Developmenttest/NyoStore/2.1/store/{store_id}/schedule")]
        [Authorize(AuthenticationSchemes = BearerAuthenticationHandler.SchemeName)]
        [ValidateModelState]
        [SwaggerOperation("AddSchedule")]
        [SwaggerResponse(statusCode: 200, type: typeof(Key), description: "successful operation")]
        [SwaggerResponse(statusCode: 400, type: typeof(Error), description: "Bad request")]
        [SwaggerResponse(statusCode: 401, type: typeof(Unauthorized), description: "Unauthorized")]
        [SwaggerResponse(statusCode: 403, type: typeof(Forbidden), description: "Forbidden")]
        [SwaggerResponse(statusCode: 404, type: typeof(Error), description: "Not Found")]
        [SwaggerResponse(statusCode: 405, type: typeof(Error), description: "Invalid input")]
        [SwaggerResponse(statusCode: 409, type: typeof(Error), description: "Conflict")]
        [SwaggerResponse(statusCode: 5XX, type: typeof(Error), description: "Unexpected Error")]
        public virtual IActionResult AddSchedule([FromRoute][Required]string storeId, [FromBody]Body13 body)
        { 
            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200, default(Key));

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
            exampleJson = "{\n  \"data\" : {\n    \"key\" : \"key\"\n  },\n  \"message\" : \"message\",\n  \"status\" : true\n}";
            
                        var example = exampleJson != null
                        ? JsonConvert.DeserializeObject<Key>(exampleJson)
                        : default(Key);            //TODO: Change the data returned
            return new ObjectResult(example);
        }

        /// <summary>
        /// Deletes a schedule
        /// </summary>
        /// <param name="storeId">Store id of store to return</param>
        /// <param name="scheduleId">Schedule id of schedules to return</param>
        /// <response code="200">Success</response>
        /// <response code="400">Bad request</response>
        /// <response code="401">Unauthorized</response>
        /// <response code="403">Forbidden</response>
        /// <response code="404">Not Found</response>
        /// <response code="405">Invalid input</response>
        /// <response code="409">Conflict</response>
        /// <response code="5XX">Unexpected Error</response>
        [HttpDelete]
        [Route("/Developmenttest/NyoStore/2.1/store/{store_id}/schedule/{schedule_id}")]
        [Authorize(AuthenticationSchemes = BearerAuthenticationHandler.SchemeName)]
        [ValidateModelState]
        [SwaggerOperation("DeleteSchedule")]
        [SwaggerResponse(statusCode: 200, type: typeof(Success), description: "Success")]
        [SwaggerResponse(statusCode: 400, type: typeof(Error), description: "Bad request")]
        [SwaggerResponse(statusCode: 401, type: typeof(Unauthorized), description: "Unauthorized")]
        [SwaggerResponse(statusCode: 403, type: typeof(Forbidden), description: "Forbidden")]
        [SwaggerResponse(statusCode: 404, type: typeof(Error), description: "Not Found")]
        [SwaggerResponse(statusCode: 405, type: typeof(Error), description: "Invalid input")]
        [SwaggerResponse(statusCode: 409, type: typeof(Error), description: "Conflict")]
        [SwaggerResponse(statusCode: 5XX, type: typeof(Error), description: "Unexpected Error")]
        public virtual IActionResult DeleteSchedule([FromRoute][Required]string storeId, [FromRoute][Required]string scheduleId)
        { 
            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200, default(Success));

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
            exampleJson = "{\n  \"message\" : \"message\",\n  \"status\" : true\n}";
            
                        var example = exampleJson != null
                        ? JsonConvert.DeserializeObject<Success>(exampleJson)
                        : default(Success);            //TODO: Change the data returned
            return new ObjectResult(example);
        }

        /// <summary>
        /// Deletes a timeslot
        /// </summary>
        /// <param name="storeId">Store id of store to return</param>
        /// <param name="scheduleId">Schedule id of schedules to return</param>
        /// <param name="key">Key of timeslot to return</param>
        /// <response code="200">Success</response>
        /// <response code="400">Bad request</response>
        /// <response code="401">Unauthorized</response>
        /// <response code="403">Forbidden</response>
        /// <response code="404">Not Found</response>
        /// <response code="405">Invalid input</response>
        /// <response code="409">Conflict</response>
        /// <response code="5XX">Unexpected Error</response>
        [HttpDelete]
        [Route("/Developmenttest/NyoStore/2.1/store/{store_id}/schedule/{schedule_id}/timeslot/{key}")]
        [Authorize(AuthenticationSchemes = BearerAuthenticationHandler.SchemeName)]
        [ValidateModelState]
        [SwaggerOperation("DeleteTimeslot")]
        [SwaggerResponse(statusCode: 200, type: typeof(Success), description: "Success")]
        [SwaggerResponse(statusCode: 400, type: typeof(Error), description: "Bad request")]
        [SwaggerResponse(statusCode: 401, type: typeof(Unauthorized), description: "Unauthorized")]
        [SwaggerResponse(statusCode: 403, type: typeof(Forbidden), description: "Forbidden")]
        [SwaggerResponse(statusCode: 404, type: typeof(Error), description: "Not Found")]
        [SwaggerResponse(statusCode: 405, type: typeof(Error), description: "Invalid input")]
        [SwaggerResponse(statusCode: 409, type: typeof(Error), description: "Conflict")]
        [SwaggerResponse(statusCode: 5XX, type: typeof(Error), description: "Unexpected Error")]
        public virtual IActionResult DeleteTimeslot([FromRoute][Required]string storeId, [FromRoute][Required]string scheduleId, [FromRoute][Required]string key)
        { 
            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200, default(Success));

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
            exampleJson = "{\n  \"message\" : \"message\",\n  \"status\" : true\n}";
            
                        var example = exampleJson != null
                        ? JsonConvert.DeserializeObject<Success>(exampleJson)
                        : default(Success);            //TODO: Change the data returned
            return new ObjectResult(example);
        }

        /// <summary>
        /// Get schedules
        /// </summary>
        /// <remarks>Returns a single schedule</remarks>
        /// <param name="storeId">Store id of store to return</param>
        /// <param name="scheduleId">Schedule id of schedules to return</param>
        /// <response code="200">successful operation</response>
        /// <response code="400">Bad request</response>
        /// <response code="401">Unauthorized</response>
        /// <response code="403">Forbidden</response>
        /// <response code="404">Not Found</response>
        /// <response code="405">Invalid input</response>
        /// <response code="409">Conflict</response>
        /// <response code="5XX">Unexpected Error</response>
        [HttpGet]
        [Route("/Developmenttest/NyoStore/2.1/store/{store_id}/schedule/{schedule_id}")]
        [Authorize(AuthenticationSchemes = BearerAuthenticationHandler.SchemeName)]
        [ValidateModelState]
        [SwaggerOperation("GetScheduleById")]
        [SwaggerResponse(statusCode: 200, type: typeof(ScheduleById), description: "successful operation")]
        [SwaggerResponse(statusCode: 400, type: typeof(Error), description: "Bad request")]
        [SwaggerResponse(statusCode: 401, type: typeof(Unauthorized), description: "Unauthorized")]
        [SwaggerResponse(statusCode: 403, type: typeof(Forbidden), description: "Forbidden")]
        [SwaggerResponse(statusCode: 404, type: typeof(Error), description: "Not Found")]
        [SwaggerResponse(statusCode: 405, type: typeof(Error), description: "Invalid input")]
        [SwaggerResponse(statusCode: 409, type: typeof(Error), description: "Conflict")]
        [SwaggerResponse(statusCode: 5XX, type: typeof(Error), description: "Unexpected Error")]
        public virtual IActionResult GetScheduleById([FromRoute][Required]string storeId, [FromRoute][Required]string scheduleId)
        { 
            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200, default(ScheduleById));

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
            exampleJson = "{\n  \"data\" : {\n    \"policy_id\" : \"policy_id\",\n    \"timezone\" : \"timezone\",\n    \"name\" : \"name\",\n    \"schedule_id\" : \"schedule_id\",\n    \"timeslots\" : \"timeslots\"\n  },\n  \"message\" : \"message\",\n  \"status\" : true\n}";
            
                        var example = exampleJson != null
                        ? JsonConvert.DeserializeObject<ScheduleById>(exampleJson)
                        : default(ScheduleById);            //TODO: Change the data returned
            return new ObjectResult(example);
        }

        /// <summary>
        /// Get schedules
        /// </summary>
        /// <remarks>Returns all schedules</remarks>
        /// <param name="storeId">Store id of store to return</param>
        /// <response code="200">successful operation</response>
        /// <response code="400">Bad request</response>
        /// <response code="401">Unauthorized</response>
        /// <response code="403">Forbidden</response>
        /// <response code="404">Not Found</response>
        /// <response code="405">Invalid input</response>
        /// <response code="409">Conflict</response>
        /// <response code="5XX">Unexpected Error</response>
        [HttpGet]
        [Route("/Developmenttest/NyoStore/2.1/store/{store_id}/schedules")]
        [Authorize(AuthenticationSchemes = BearerAuthenticationHandler.SchemeName)]
        [ValidateModelState]
        [SwaggerOperation("GetSchedules")]
        [SwaggerResponse(statusCode: 200, type: typeof(Schedules), description: "successful operation")]
        [SwaggerResponse(statusCode: 400, type: typeof(Error), description: "Bad request")]
        [SwaggerResponse(statusCode: 401, type: typeof(Unauthorized), description: "Unauthorized")]
        [SwaggerResponse(statusCode: 403, type: typeof(Forbidden), description: "Forbidden")]
        [SwaggerResponse(statusCode: 404, type: typeof(Error), description: "Not Found")]
        [SwaggerResponse(statusCode: 405, type: typeof(Error), description: "Invalid input")]
        [SwaggerResponse(statusCode: 409, type: typeof(Error), description: "Conflict")]
        [SwaggerResponse(statusCode: 5XX, type: typeof(Error), description: "Unexpected Error")]
        public virtual IActionResult GetSchedules([FromRoute][Required]string storeId)
        { 
            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200, default(Schedules));

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
            exampleJson = "{\n  \"data\" : [ {\n    \"timezone\" : \"timezone\",\n    \"name\" : \"name\",\n    \"schedule_id\" : \"schedule_id\"\n  }, {\n    \"timezone\" : \"timezone\",\n    \"name\" : \"name\",\n    \"schedule_id\" : \"schedule_id\"\n  } ],\n  \"message\" : \"message\",\n  \"status\" : true\n}";
            
                        var example = exampleJson != null
                        ? JsonConvert.DeserializeObject<Schedules>(exampleJson)
                        : default(Schedules);            //TODO: Change the data returned
            return new ObjectResult(example);
        }

        /// <summary>
        /// Update name of schedule by address id
        /// </summary>
        /// <remarks>Update name</remarks>
        /// <param name="storeId">Store id of store to return</param>
        /// <param name="scheduleId">Schedule id of schedules to return</param>
        /// <param name="body"></param>
        /// <response code="200">Success</response>
        /// <response code="400">Bad request</response>
        /// <response code="401">Unauthorized</response>
        /// <response code="403">Forbidden</response>
        /// <response code="404">Not Found</response>
        /// <response code="405">Invalid input</response>
        /// <response code="409">Conflict</response>
        /// <response code="5XX">Unexpected Error</response>
        [HttpPatch]
        [Route("/Developmenttest/NyoStore/2.1/store/{store_id}/schedule/{schedule_id}")]
        [Authorize(AuthenticationSchemes = BearerAuthenticationHandler.SchemeName)]
        [ValidateModelState]
        [SwaggerOperation("PatchScheduleNameById")]
        [SwaggerResponse(statusCode: 200, type: typeof(Success), description: "Success")]
        [SwaggerResponse(statusCode: 400, type: typeof(Error), description: "Bad request")]
        [SwaggerResponse(statusCode: 401, type: typeof(Unauthorized), description: "Unauthorized")]
        [SwaggerResponse(statusCode: 403, type: typeof(Forbidden), description: "Forbidden")]
        [SwaggerResponse(statusCode: 404, type: typeof(Error), description: "Not Found")]
        [SwaggerResponse(statusCode: 405, type: typeof(Error), description: "Invalid input")]
        [SwaggerResponse(statusCode: 409, type: typeof(Error), description: "Conflict")]
        [SwaggerResponse(statusCode: 5XX, type: typeof(Error), description: "Unexpected Error")]
        public virtual IActionResult PatchScheduleNameById([FromRoute][Required]string storeId, [FromRoute][Required]string scheduleId, [FromBody]Body14 body)
        { 
            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200, default(Success));

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
            exampleJson = "{\n  \"message\" : \"message\",\n  \"status\" : true\n}";
            
                        var example = exampleJson != null
                        ? JsonConvert.DeserializeObject<Success>(exampleJson)
                        : default(Success);            //TODO: Change the data returned
            return new ObjectResult(example);
        }

        /// <summary>
        /// Update timeslot of schedule by address id
        /// </summary>
        /// <remarks>Update timeslot</remarks>
        /// <param name="storeId">Store id of store to return</param>
        /// <param name="scheduleId">Schedule id of schedules to return</param>
        /// <param name="key">Key of timeslot to return</param>
        /// <param name="body"></param>
        /// <response code="200">Success</response>
        /// <response code="400">Bad request</response>
        /// <response code="401">Unauthorized</response>
        /// <response code="403">Forbidden</response>
        /// <response code="404">Not Found</response>
        /// <response code="405">Invalid input</response>
        /// <response code="409">Conflict</response>
        /// <response code="5XX">Unexpected Error</response>
        [HttpPatch]
        [Route("/Developmenttest/NyoStore/2.1/store/{store_id}/schedule/{schedule_id}/timeslot/{key}")]
        [Authorize(AuthenticationSchemes = BearerAuthenticationHandler.SchemeName)]
        [ValidateModelState]
        [SwaggerOperation("PatchScheduleTimeslotById")]
        [SwaggerResponse(statusCode: 200, type: typeof(Success), description: "Success")]
        [SwaggerResponse(statusCode: 400, type: typeof(Error), description: "Bad request")]
        [SwaggerResponse(statusCode: 401, type: typeof(Unauthorized), description: "Unauthorized")]
        [SwaggerResponse(statusCode: 403, type: typeof(Forbidden), description: "Forbidden")]
        [SwaggerResponse(statusCode: 404, type: typeof(Error), description: "Not Found")]
        [SwaggerResponse(statusCode: 405, type: typeof(Error), description: "Invalid input")]
        [SwaggerResponse(statusCode: 409, type: typeof(Error), description: "Conflict")]
        [SwaggerResponse(statusCode: 5XX, type: typeof(Error), description: "Unexpected Error")]
        public virtual IActionResult PatchScheduleTimeslotById([FromRoute][Required]string storeId, [FromRoute][Required]string scheduleId, [FromRoute][Required]string key, [FromBody]Body17 body)
        { 
            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200, default(Success));

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
            exampleJson = "{\n  \"message\" : \"message\",\n  \"status\" : true\n}";
            
                        var example = exampleJson != null
                        ? JsonConvert.DeserializeObject<Success>(exampleJson)
                        : default(Success);            //TODO: Change the data returned
            return new ObjectResult(example);
        }

        /// <summary>
        /// Update timezone of schedule by address id
        /// </summary>
        /// <remarks>Update timezone</remarks>
        /// <param name="storeId">Store id of store to return</param>
        /// <param name="scheduleId">Schedule id of schedules to return</param>
        /// <param name="body"></param>
        /// <response code="200">Success</response>
        /// <response code="400">Bad request</response>
        /// <response code="401">Unauthorized</response>
        /// <response code="403">Forbidden</response>
        /// <response code="404">Not Found</response>
        /// <response code="405">Invalid input</response>
        /// <response code="409">Conflict</response>
        /// <response code="5XX">Unexpected Error</response>
        [HttpPatch]
        [Route("/Developmenttest/NyoStore/2.1/store/{store_id}/schedule/{schedule_id}/timezone")]
        [Authorize(AuthenticationSchemes = BearerAuthenticationHandler.SchemeName)]
        [ValidateModelState]
        [SwaggerOperation("PatchScheduleTimezoneById")]
        [SwaggerResponse(statusCode: 200, type: typeof(Success), description: "Success")]
        [SwaggerResponse(statusCode: 400, type: typeof(Error), description: "Bad request")]
        [SwaggerResponse(statusCode: 401, type: typeof(Unauthorized), description: "Unauthorized")]
        [SwaggerResponse(statusCode: 403, type: typeof(Forbidden), description: "Forbidden")]
        [SwaggerResponse(statusCode: 404, type: typeof(Error), description: "Not Found")]
        [SwaggerResponse(statusCode: 405, type: typeof(Error), description: "Invalid input")]
        [SwaggerResponse(statusCode: 409, type: typeof(Error), description: "Conflict")]
        [SwaggerResponse(statusCode: 5XX, type: typeof(Error), description: "Unexpected Error")]
        public virtual IActionResult PatchScheduleTimezoneById([FromRoute][Required]string storeId, [FromRoute][Required]string scheduleId, [FromBody]Body15 body)
        { 
            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200, default(Success));

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
            exampleJson = "{\n  \"message\" : \"message\",\n  \"status\" : true\n}";
            
                        var example = exampleJson != null
                        ? JsonConvert.DeserializeObject<Success>(exampleJson)
                        : default(Success);            //TODO: Change the data returned
            return new ObjectResult(example);
        }

        /// <summary>
        /// Add timeslot of schedule by address id
        /// </summary>
        /// <remarks>Add timeslot</remarks>
        /// <param name="storeId">Store id of store to return</param>
        /// <param name="scheduleId">Schedule id of schedules to return</param>
        /// <param name="body"></param>
        /// <response code="200">successful operation</response>
        /// <response code="400">Bad request</response>
        /// <response code="401">Unauthorized</response>
        /// <response code="403">Forbidden</response>
        /// <response code="404">Not Found</response>
        /// <response code="405">Invalid input</response>
        /// <response code="409">Conflict</response>
        /// <response code="5XX">Unexpected Error</response>
        [HttpPost]
        [Route("/Developmenttest/NyoStore/2.1/store/{store_id}/schedule/{schedule_id}/timeslot")]
        [Authorize(AuthenticationSchemes = BearerAuthenticationHandler.SchemeName)]
        [ValidateModelState]
        [SwaggerOperation("PostScheduleTimeslotById")]
        [SwaggerResponse(statusCode: 200, type: typeof(Key), description: "successful operation")]
        [SwaggerResponse(statusCode: 400, type: typeof(Error), description: "Bad request")]
        [SwaggerResponse(statusCode: 401, type: typeof(Unauthorized), description: "Unauthorized")]
        [SwaggerResponse(statusCode: 403, type: typeof(Forbidden), description: "Forbidden")]
        [SwaggerResponse(statusCode: 404, type: typeof(Error), description: "Not Found")]
        [SwaggerResponse(statusCode: 405, type: typeof(Error), description: "Invalid input")]
        [SwaggerResponse(statusCode: 409, type: typeof(Error), description: "Conflict")]
        [SwaggerResponse(statusCode: 5XX, type: typeof(Error), description: "Unexpected Error")]
        public virtual IActionResult PostScheduleTimeslotById([FromRoute][Required]string storeId, [FromRoute][Required]string scheduleId, [FromBody]Body16 body)
        { 
            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200, default(Key));

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
            exampleJson = "{\n  \"data\" : {\n    \"key\" : \"key\"\n  },\n  \"message\" : \"message\",\n  \"status\" : true\n}";
            
                        var example = exampleJson != null
                        ? JsonConvert.DeserializeObject<Key>(exampleJson)
                        : default(Key);            //TODO: Change the data returned
            return new ObjectResult(example);
        }
    }
}
