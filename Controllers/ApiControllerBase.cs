﻿using EnjoyDialogs.SCIM.Data.Contracts;
using System.Web.Http;

namespace EnjoyDialogs.SCIM.Controllers
{
    public class ApiControllerBase : ApiController
    {
        protected IUnitOfWork Uow { get; set; }

        // NOT NECESSARY TO DISPOSE THE UOW IN OUR CONTROLLERS
        // Recall that we let IoC inject the Uow into our controllers
        // We can depend upon on IoC to dispose the UoW for us
        // when Web API disposes the IoC container.        
        // 
        // IF YOU DIDN'T USE IoC, WE WOULD NEED THE FOLLOWING
        //
        //// base ApiController is IDisposable
        //// Dispose of the repository if it is IDisposable
        //protected override void Dispose(bool disposing)
        //{
        //    if (Uow != null && Uow is IDisposable)
        //    {
        //        ((IDisposable)Uow).Dispose();
        //        Uow = null;
        //    }
        //    base.Dispose(disposing);
        //}
    }
}