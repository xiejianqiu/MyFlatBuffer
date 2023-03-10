// automatically generated, do not modify

namespace Shark
{

using FlatBuffers;

public sealed class FB_KneadFaceOClothing : Table {
  public static FB_KneadFaceOClothing GetRootAsFB_KneadFaceOClothing(ByteBuffer _bb) { return GetRootAsFB_KneadFaceOClothing(_bb, new FB_KneadFaceOClothing()); }
  public static FB_KneadFaceOClothing GetRootAsFB_KneadFaceOClothing(ByteBuffer _bb, FB_KneadFaceOClothing obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public FB_KneadFaceOClothing __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public int Id { get { int o = __offset(4); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int MenPai { get { int o = __offset(6); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int Sex { get { int o = __offset(8); return o != 0 ? bb.GetInt(o + bb_pos) : (int)1; } }
  public int PupilColor { get { int o = __offset(10); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public string PupilIcon { get { int o = __offset(12); return o != 0 ? __string(o + bb_pos) : null; } }
  public int HairModelId { get { int o = __offset(14); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public string HairModelIcon { get { int o = __offset(16); return o != 0 ? __string(o + bb_pos) : null; } }
  public int PlayerSkinBaseId { get { int o = __offset(18); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }

  public static Offset<FB_KneadFaceOClothing> CreateFB_KneadFaceOClothing(FlatBufferBuilder builder,
      int Id = 0,
      int MenPai = -1,
      int Sex = 1,
      int PupilColor = -1,
      StringOffset PupilIcon = default(StringOffset),
      int HairModelId = -1,
      StringOffset HairModelIcon = default(StringOffset),
      int PlayerSkinBaseId = -1) {
    builder.StartObject(8);
    FB_KneadFaceOClothing.AddPlayerSkinBaseId(builder, PlayerSkinBaseId);
    FB_KneadFaceOClothing.AddHairModelIcon(builder, HairModelIcon);
    FB_KneadFaceOClothing.AddHairModelId(builder, HairModelId);
    FB_KneadFaceOClothing.AddPupilIcon(builder, PupilIcon);
    FB_KneadFaceOClothing.AddPupilColor(builder, PupilColor);
    FB_KneadFaceOClothing.AddSex(builder, Sex);
    FB_KneadFaceOClothing.AddMenPai(builder, MenPai);
    FB_KneadFaceOClothing.AddId(builder, Id);
    return FB_KneadFaceOClothing.EndFB_KneadFaceOClothing(builder);
  }

  public static void StartFB_KneadFaceOClothing(FlatBufferBuilder builder) { builder.StartObject(8); }
  public static void AddId(FlatBufferBuilder builder, int Id) { builder.AddInt(0, Id, 0); }
  public static void AddMenPai(FlatBufferBuilder builder, int MenPai) { builder.AddInt(1, MenPai, -1); }
  public static void AddSex(FlatBufferBuilder builder, int Sex) { builder.AddInt(2, Sex, 1); }
  public static void AddPupilColor(FlatBufferBuilder builder, int PupilColor) { builder.AddInt(3, PupilColor, -1); }
  public static void AddPupilIcon(FlatBufferBuilder builder, StringOffset PupilIconOffset) { builder.AddOffset(4, PupilIconOffset.Value, 0); }
  public static void AddHairModelId(FlatBufferBuilder builder, int HairModelId) { builder.AddInt(5, HairModelId, -1); }
  public static void AddHairModelIcon(FlatBufferBuilder builder, StringOffset HairModelIconOffset) { builder.AddOffset(6, HairModelIconOffset.Value, 0); }
  public static void AddPlayerSkinBaseId(FlatBufferBuilder builder, int PlayerSkinBaseId) { builder.AddInt(7, PlayerSkinBaseId, -1); }
  public static Offset<FB_KneadFaceOClothing> EndFB_KneadFaceOClothing(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_KneadFaceOClothing>(o);
  }
};

public sealed class FB_KneadFaceOClothingContainer : Table {
  public static FB_KneadFaceOClothingContainer GetRootAsFB_KneadFaceOClothingContainer(ByteBuffer _bb) { return GetRootAsFB_KneadFaceOClothingContainer(_bb, new FB_KneadFaceOClothingContainer()); }
  public static FB_KneadFaceOClothingContainer GetRootAsFB_KneadFaceOClothingContainer(ByteBuffer _bb, FB_KneadFaceOClothingContainer obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public static bool FB_KneadFaceOClothingContainerBufferHasIdentifier(ByteBuffer _bb) { return __has_identifier(_bb, "swdt"); }
  public FB_KneadFaceOClothingContainer __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public FB_KneadFaceOClothing GetItems(int j) { return GetItems(new FB_KneadFaceOClothing(), j); }
  public FB_KneadFaceOClothing GetItems(FB_KneadFaceOClothing obj, int j) { int o = __offset(4); return o != 0 ? obj.__init(__indirect(__vector(o) + j * 4), bb) : null; }
  public int ItemsLength { get { int o = __offset(4); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_KneadFaceOClothingContainer> CreateFB_KneadFaceOClothingContainer(FlatBufferBuilder builder,
      VectorOffset items = default(VectorOffset)) {
    builder.StartObject(1);
    FB_KneadFaceOClothingContainer.AddItems(builder, items);
    return FB_KneadFaceOClothingContainer.EndFB_KneadFaceOClothingContainer(builder);
  }

  public static void StartFB_KneadFaceOClothingContainer(FlatBufferBuilder builder) { builder.StartObject(1); }
  public static void AddItems(FlatBufferBuilder builder, VectorOffset itemsOffset) { builder.AddOffset(0, itemsOffset.Value, 0); }
  public static VectorOffset CreateItemsVector(FlatBufferBuilder builder, Offset<FB_KneadFaceOClothing>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static void StartItemsVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_KneadFaceOClothingContainer> EndFB_KneadFaceOClothingContainer(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_KneadFaceOClothingContainer>(o);
  }
  public static void FinishFB_KneadFaceOClothingContainerBuffer(FlatBufferBuilder builder, Offset<FB_KneadFaceOClothingContainer> offset) { builder.Finish(offset.Value, "swdt"); }
};


}
