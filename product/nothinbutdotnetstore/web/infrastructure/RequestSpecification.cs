namespace nothinbutdotnetstore.web.infrastructure
{
    public delegate bool RequestSpecification(Request request);

    public delegate IList<RequestDepartments> GetDepatmentList(Request request );

}

