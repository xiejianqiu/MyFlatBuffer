// automatically generated, do not modify

namespace Shark
{

using FlatBuffers;

public sealed class FB_PlayerSkinPart : Table {
  public static FB_PlayerSkinPart GetRootAsFB_PlayerSkinPart(ByteBuffer _bb) { return GetRootAsFB_PlayerSkinPart(_bb, new FB_PlayerSkinPart()); }
  public static FB_PlayerSkinPart GetRootAsFB_PlayerSkinPart(ByteBuffer _bb, FB_PlayerSkinPart obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public FB_PlayerSkinPart __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public int ID { get { int o = __offset(4); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public string Name { get { int o = __offset(6); return o != 0 ? __string(o + bb_pos) : null; } }
  public int DefaultColor { get { int o = __offset(8); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int CustomColorID { get { int o = __offset(10); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int GetRecommendColorIDList(int j) { int o = __offset(12); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int RecommendColorIDListLength { get { int o = __offset(12); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_PlayerSkinPart> CreateFB_PlayerSkinPart(FlatBufferBuilder builder,
      int ID = 0,
      StringOffset Name = default(StringOffset),
      int DefaultColor = -1,
      int CustomColorID = -1,
      VectorOffset RecommendColorIDList = default(VectorOffset)) {
    builder.StartObject(5);
    FB_PlayerSkinPart.AddRecommendColorIDList(builder, RecommendColorIDList);
    FB_PlayerSkinPart.AddCustomColorID(builder, CustomColorID);
    FB_PlayerSkinPart.AddDefaultColor(builder, DefaultColor);
    FB_PlayerSkinPart.AddName(builder, Name);
    FB_PlayerSkinPart.AddID(builder, ID);
    return FB_PlayerSkinPart.EndFB_PlayerSkinPart(builder);
  }

  public static void StartFB_PlayerSkinPart(FlatBufferBuilder builder) { builder.StartObject(5); }
  public static void AddID(FlatBufferBuilder builder, int ID) { builder.AddInt(0, ID, 0); }
  public static void AddName(FlatBufferBuilder builder, StringOffset NameOffset) { builder.AddOffset(1, NameOffset.Value, 0); }
  public static void AddDefaultColor(FlatBufferBuilder builder, int DefaultColor) { builder.AddInt(2, DefaultColor, -1); }
  public static void AddCustomColorID(FlatBufferBuilder builder, int CustomColorID) { builder.AddInt(3, CustomColorID, -1); }
  public static void AddRecommendColorIDList(FlatBufferBuilder builder, VectorOffset RecommendColorIDListOffset) { builder.AddOffset(4, RecommendColorIDListOffset.Value, 0); }
  public static VectorOffset CreateRecommendColorIDListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartRecommendColorIDListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_PlayerSkinPart> EndFB_PlayerSkinPart(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_PlayerSkinPart>(o);
  }
};

public sealed class FB_PlayerSkinPartContainer : Table {
  public static FB_PlayerSkinPartContainer GetRootAsFB_PlayerSkinPartContainer(ByteBuffer _bb) { return GetRootAsFB_PlayerSkinPartContainer(_bb, new FB_PlayerSkinPartContainer()); }
  public static FB_PlayerSkinPartContainer GetRootAsFB_PlayerSkinPartContainer(ByteBuffer _bb, FB_PlayerSkinPartContainer obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public static bool FB_PlayerSkinPartContainerBufferHasIdentifier(ByteBuffer _bb) { return __has_identifier(_bb, "swdt"); }
  public FB_PlayerSkinPartContainer __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public FB_PlayerSkinPart GetItems(int j) { return GetItems(new FB_PlayerSkinPart(), j); }
  public FB_PlayerSkinPart GetItems(FB_PlayerSkinPart obj, int j) { int o = __offset(4); return o != 0 ? obj.__init(__indirect(__vector(o) + j * 4), bb) : null; }
  public int ItemsLength { get { int o = __offset(4); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_PlayerSkinPartContainer> CreateFB_PlayerSkinPartContainer(FlatBufferBuilder builder,
      VectorOffset items = default(VectorOffset)) {
    builder.StartObject(1);
    FB_PlayerSkinPartContainer.AddItems(builder, items);
    return FB_PlayerSkinPartContainer.EndFB_PlayerSkinPartContainer(builder);
  }

  public static void StartFB_PlayerSkinPartContainer(FlatBufferBuilder builder) { builder.StartObject(1); }
  public static void AddItems(FlatBufferBuilder builder, VectorOffset itemsOffset) { builder.AddOffset(0, itemsOffset.Value, 0); }
  public static VectorOffset CreateItemsVector(FlatBufferBuilder builder, Offset<FB_PlayerSkinPart>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static void StartItemsVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_PlayerSkinPartContainer> EndFB_PlayerSkinPartContainer(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_PlayerSkinPartContainer>(o);
  }
  public static void FinishFB_PlayerSkinPartContainerBuffer(FlatBufferBuilder builder, Offset<FB_PlayerSkinPartContainer> offset) { builder.Finish(offset.Value, "swdt"); }
};


}
