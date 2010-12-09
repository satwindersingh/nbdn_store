 using Machine.Specifications;
 using Machine.Specifications.DevelopWithPassion.Rhino;
 using nothinbutdotnetstore.web;
 using nothinbutdotnetstore.web.application;
 using nothinbutdotnetstore.web.infrastructure;

namespace nothinbutdotnetstore.specs.web
{   
    public class ViewMainDepartmentsInTheStoreSpecs
    {
        public abstract class concern : Observes<ApplicationCommand,
                                            ViewMainDepartmentsInTheStore>
        {
        
        }

        [Subject(typeof(ViewMainDepartmentsInTheStore))]
        public class when_observation_name : concern
        {

            Establish c = () =>
            {
                request = an<Request>();
                provide_a_basic_sut_constructor_argument<RequestSpecification>(x =>
                {
                    deps = new IList<RequestDepartments>();
                    return IList<RequestDepartments>;
                });



                var depatmemts = new IList<RequestDepartments>();
            };
            Because b = () =>
                result = sut.process(request);

            It should_make_the_determination_by_using_its_request_specification = () =>
            {
                result.ShouldBeTrue();
                was_called.ShouldBeTrue();
            };

            static Request request;
            static bool result;
            private static IList<RequestDepartments> deps;
        }
    }
}
