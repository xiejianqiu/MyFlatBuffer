// automatically generated, do not modify

namespace Shark
{

using FlatBuffers;

public sealed class FB_HuanJingType : Table {
  public static FB_HuanJingType GetRootAsFB_HuanJingType(ByteBuffer _bb) { return GetRootAsFB_HuanJingType(_bb, new FB_HuanJingType()); }
  public static FB_HuanJingType GetRootAsFB_HuanJingType(ByteBuffer _bb, FB_HuanJingType obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public FB_HuanJingType __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public int Id { get { int o = __offset(4); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public string WorldName { get { int o = __offset(6); return o != 0 ? __string(o + bb_pos) : null; } }
  public int WorldId { get { int o = __offset(8); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public string Name { get { int o = __offset(10); return o != 0 ? __string(o + bb_pos) : null; } }
  public string GetIconList(int j) { int o = __offset(12); return o != 0 ? __string(__vector(o) + j * 4) : null; }
  public int IconListLength { get { int o = __offset(12); return o != 0 ? __vector_len(o) : 0; } }
  public int Flagid { get { int o = __offset(14); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public string UIIcon { get { int o = __offset(16); return o != 0 ? __string(o + bb_pos) : null; } }
  public string LeftEffect { get { int o = __offset(18); return o != 0 ? __string(o + bb_pos) : null; } }

  public static Offset<FB_HuanJingType> CreateFB_HuanJingType(FlatBufferBuilder builder,
      int Id = 0,
      StringOffset WorldName = default(StringOffset),
      int WorldId = -1,
      StringOffset Name = default(StringOffset),
      VectorOffset IconList = default(VectorOffset),
      int Flagid = -1,
      StringOffset UIIcon = default(StringOffset),
      StringOffset LeftEffect = default(StringOffset)) {
    builder.StartObject(8);
    FB_HuanJingType.AddLeftEffect(builder, LeftEffect);
    FB_HuanJingType.AddUIIcon(builder, UIIcon);
    FB_HuanJingType.AddFlagid(builder, Flagid);
    FB_HuanJingType.AddIconList(builder, IconList);
    FB_HuanJingType.AddName(builder, Name);
    FB_HuanJingType.AddWorldId(builder, WorldId);
    FB_HuanJingType.AddWorldName(builder, WorldName);
    FB_HuanJingType.AddId(builder, Id);
    return FB_HuanJingType.EndFB_HuanJingType(builder);
  }

  public static void StartFB_HuanJingType(FlatBufferBuilder builder) { builder.StartObject(8); }
  public static void AddId(FlatBufferBuilder builder, int Id) { builder.AddInt(0, Id, 0); }
  public static void AddWorldName(FlatBufferBuilder builder, StringOffset WorldNameOffset) { builder.AddOffset(1, WorldNameOffset.Value, 0); }
  public static void AddWorldId(FlatBufferBuilder builder, int WorldId) { builder.AddInt(2, WorldId, -1); }
  public static void AddName(FlatBufferBuilder builder, StringOffset NameOffset) { builder.AddOffset(3, NameOffset.Value, 0); }
  public static void AddIconList(FlatBufferBuilder builder, VectorOffset IconListOffset) { builder.AddOffset(4, IconListOffset.Value, 0); }
  public static VectorOffset CreateIconListVector(FlatBufferBuilder builder, StringOffset[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static void StartIconListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddFlagid(FlatBufferBuilder builder, int Flagid) { builder.AddInt(5, Flagid, -1); }
  public static void AddUIIcon(FlatBufferBuilder builder, StringOffset UIIconOffset) { builder.AddOffset(6, UIIconOffset.Value, 0); }
  public static void AddLeftEffect(FlatBufferBuilder builder, StringOffset LeftEffectOffset) { builder.AddOffset(7, LeftEffectOffset.Value, 0); }
  public static Offset<FB_HuanJingType> EndFB_HuanJingType(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_HuanJingType>(o);
  }
};

public sealed class FB_HuanJingTypeContainer : Table {
  public static FB_HuanJingTypeContainer GetRootAsFB_HuanJingTypeContainer(ByteBuffer _bb) { return GetRootAsFB_HuanJingTypeContainer(_bb, new FB_HuanJingTypeContainer()); }
  public static FB_HuanJingTypeContainer GetRootAsFB_HuanJingTypeContainer(ByteBuffer _bb, FB_HuanJingTypeContainer obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public static bool FB_HuanJingTypeContainerBufferHasIdentifier(ByteBuffer _bb) { return __has_identifier(_bb, "swdt"); }
  public FB_HuanJingTypeContainer __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public FB_HuanJingType GetItems(int j) { return GetItems(new FB_HuanJingType(), j); }
  public FB_HuanJingType GetItems(FB_HuanJingType obj, int j) { int o = __offset(4); return o != 0 ? obj.__init(__indirect(__vector(o) + j * 4), bb) : null; }
  public int ItemsLength { get { int o = __offset(4); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_HuanJingTypeContainer> CreateFB_HuanJingTypeContainer(FlatBufferBuilder builder,
      VectorOffset items = default(VectorOffset)) {
    builder.StartObject(1);
    FB_HuanJingTypeContainer.AddItems(builder, items);
    return FB_HuanJingTypeContainer.EndFB_HuanJingTypeContainer(builder);
  }

  public static void StartFB_HuanJingTypeContainer(FlatBufferBuilder builder) { builder.StartObject(1); }
  public static void AddItems(FlatBufferBuilder builder, VectorOffset itemsOffset) { builder.AddOffset(0, itemsOffset.Value, 0); }
  public static VectorOffset CreateItemsVector(FlatBufferBuilder builder, Offset<FB_HuanJingType>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static void StartItemsVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_HuanJingTypeContainer> EndFB_HuanJingTypeContainer(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_HuanJingTypeContainer>(o);
  }
  public static void FinishFB_HuanJingTypeContainerBuffer(FlatBufferBuilder builder, Offset<FB_HuanJingTypeContainer> offset) { builder.Finish(offset.Value, "swdt"); }
};


}
