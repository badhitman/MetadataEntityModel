using System.Collections.Generic;

namespace MetadataEntityModel
{
    public class base_delivery_model : RootEntityModel
    {
        public string Name { get; set; }

        public List<GalleryModel> Galleries { get; set; }
    }
}
