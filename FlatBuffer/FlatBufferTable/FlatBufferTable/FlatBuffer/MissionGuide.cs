// automatically generated, do not modify

namespace Shark
{

using FlatBuffers;

public sealed class FB_MissionGuide : Table {
  public static FB_MissionGuide GetRootAsFB_MissionGuide(ByteBuffer _bb) { return GetRootAsFB_MissionGuide(_bb, new FB_MissionGuide()); }
  public static FB_MissionGuide GetRootAsFB_MissionGuide(ByteBuffer _bb, FB_MissionGuide obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public FB_MissionGuide __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public int Id { get { int o = __offset(4); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int GuideTypeID { get { int o = __offset(6); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int AttrType { get { int o = __offset(8); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int AttrParam { get { int o = __offset(10); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int OpenUIID { get { int o = __offset(12); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }

  public static Offset<FB_MissionGuide> CreateFB_MissionGuide(FlatBufferBuilder builder,
      int Id = 0,
      int GuideTypeID = -1,
      int AttrType = -1,
      int AttrParam = -1,
      int OpenUIID = -1) {
    builder.StartObject(5);
    FB_MissionGuide.AddOpenUIID(builder, OpenUIID);
    FB_MissionGuide.AddAttrParam(builder, AttrParam);
    FB_MissionGuide.AddAttrType(builder, AttrType);
    FB_MissionGuide.AddGuideTypeID(builder, GuideTypeID);
    FB_MissionGuide.AddId(builder, Id);
    return FB_MissionGuide.EndFB_MissionGuide(builder);
  }

  public static void StartFB_MissionGuide(FlatBufferBuilder builder) { builder.StartObject(5); }
  public static void AddId(FlatBufferBuilder builder, int Id) { builder.AddInt(0, Id, 0); }
  public static void AddGuideTypeID(FlatBufferBuilder builder, int GuideTypeID) { builder.AddInt(1, GuideTypeID, -1); }
  public static void AddAttrType(FlatBufferBuilder builder, int AttrType) { builder.AddInt(2, AttrType, -1); }
  public static void AddAttrParam(FlatBufferBuilder builder, int AttrParam) { builder.AddInt(3, AttrParam, -1); }
  public static void AddOpenUIID(FlatBufferBuilder builder, int OpenUIID) { builder.AddInt(4, OpenUIID, -1); }
  public static Offset<FB_MissionGuide> EndFB_MissionGuide(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_MissionGuide>(o);
  }
};

public sealed class FB_MissionGuideContainer : Table {
  public static FB_MissionGuideContainer GetRootAsFB_MissionGuideContainer(ByteBuffer _bb) { return GetRootAsFB_MissionGuideContainer(_bb, new FB_MissionGuideContainer()); }
  public static FB_MissionGuideContainer GetRootAsFB_MissionGuideContainer(ByteBuffer _bb, FB_MissionGuideContainer obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public static bool FB_MissionGuideContainerBufferHasIdentifier(ByteBuffer _bb) { return __has_identifier(_bb, "swdt"); }
  public FB_MissionGuideContainer __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public FB_MissionGuide GetItems(int j) { return GetItems(new FB_MissionGuide(), j); }
  public FB_MissionGuide GetItems(FB_MissionGuide obj, int j) { int o = __offset(4); return o != 0 ? obj.__init(__indirect(__vector(o) + j * 4), bb) : null; }
  public int ItemsLength { get { int o = __offset(4); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_MissionGuideContainer> CreateFB_MissionGuideContainer(FlatBufferBuilder builder,
      VectorOffset items = default(VectorOffset)) {
    builder.StartObject(1);
    FB_MissionGuideContainer.AddItems(builder, items);
    return FB_MissionGuideContainer.EndFB_MissionGuideContainer(builder);
  }

  public static void StartFB_MissionGuideContainer(FlatBufferBuilder builder) { builder.StartObject(1); }
  public static void AddItems(FlatBufferBuilder builder, VectorOffset itemsOffset) { builder.AddOffset(0, itemsOffset.Value, 0); }
  public static VectorOffset CreateItemsVector(FlatBufferBuilder builder, Offset<FB_MissionGuide>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static void StartItemsVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_MissionGuideContainer> EndFB_MissionGuideContainer(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_MissionGuideContainer>(o);
  }
  public static void FinishFB_MissionGuideContainerBuffer(FlatBufferBuilder builder, Offset<FB_MissionGuideContainer> offset) { builder.Finish(offset.Value, "swdt"); }
};


}
