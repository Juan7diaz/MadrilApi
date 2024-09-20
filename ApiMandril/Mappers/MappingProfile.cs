using ApiMandril.Dto.Group;
using ApiMandril.Dto.Post;
using ApiMandril.Dto.Profile;
using ApiMandril.Dto.user; // hay que revisar porque está tomando "user" y no "User"
using ApiMandril.Dto.UserGroup;
using ApiMandril.Models;
using Profile = AutoMapper.Profile;

namespace ApiMandril.Mappers
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            // Mapeos para User
            CreateMap<User, UserDto>();
            CreateMap<UserDto, User>();
            CreateMap<User, UserDtoToSave>();
            CreateMap<UserDtoToSave, User>();

            // Mapeos para Profile
            CreateMap<Profile, ProfileDto>();
            CreateMap<ProfileDto, Profile>();
            CreateMap<Profile, ProfileDtoToSave>();
            CreateMap<ProfileDtoToSave, Profile>();

            // Mapeos para Post
            CreateMap<Post, PostDto>();
            CreateMap<PostDto, Post>();
            CreateMap<Post, PostDtoToSave>();
            CreateMap<PostDtoToSave, Post>();

            // Mapeos para Group
            CreateMap<Group, GroupDto>();
            CreateMap<GroupDto, Group>();
            CreateMap<Group, GroupDtoToSave>();
            CreateMap<GroupDtoToSave, Group>();

            // Mapeos para UserGroup
            CreateMap<UserGroup, UserGroupDto>();
            CreateMap<UserGroupDto, UserGroup>();
            CreateMap<UserGroup, UserGroupDtoToSave>();
            CreateMap<UserGroupDtoToSave, UserGroup>();
        }
    }
}