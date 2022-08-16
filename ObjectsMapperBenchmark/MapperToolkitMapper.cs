using System.Linq;
using MapperToolkit;

namespace ObjectsMapperBenchmark;

internal class MapperToolkitMapper : Profile
{
    public MapperToolkitMapper()
    {
        GenerateAllMapper<ArtistDto, Artist>();
        GenerateAllMapper<TracksDto, Tracks>();
        GenerateAllMapper<CopyrightDto, Copyright>();
        GenerateAllMapper<ImageDto, Image>();
        GenerateAllMapper<ExternalIdsDto, ExternalIds>();
        GenerateAllMapper<ExternalUrlsDto, ExternalUrls>();
        GenerateAllMapper<ItemDto, Item>();
        GenerateAllMapper<SpotifyAlbumDto, SpotifyAlbum>();
    }
}
