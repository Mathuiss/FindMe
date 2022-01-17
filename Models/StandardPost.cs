using Piranha.AttributeBuilder;
using Piranha.Models;

namespace FindMe.Models
{
    [PostType(Title = "Standard post")]
    public class StandardPost  : Post<StandardPost>
    {
    }
}