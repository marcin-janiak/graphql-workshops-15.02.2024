using _02_Domain;

namespace _02_Host.GraphQL.Groups;

public class GroupObjectType : ObjectType<Group>
{
    protected override void Configure(IObjectTypeDescriptor<Group> descriptor)
    {
        base.Configure(descriptor);
        descriptor.Field(x => x.Id).IsProjected();
        descriptor.Field(x => x.OwnerId).IsProjected();
    }
}