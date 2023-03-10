// automatically generated, do not modify

namespace Shark
{

using FlatBuffers;

public sealed class FB_HuanJingEquip : Table {
  public static FB_HuanJingEquip GetRootAsFB_HuanJingEquip(ByteBuffer _bb) { return GetRootAsFB_HuanJingEquip(_bb, new FB_HuanJingEquip()); }
  public static FB_HuanJingEquip GetRootAsFB_HuanJingEquip(ByteBuffer _bb, FB_HuanJingEquip obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public FB_HuanJingEquip __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public int ID { get { int o = __offset(4); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public string TitleEquip { get { int o = __offset(6); return o != 0 ? __string(o + bb_pos) : null; } }
  public string TitleEquipInfo { get { int o = __offset(8); return o != 0 ? __string(o + bb_pos) : null; } }
  public int Quality { get { int o = __offset(10); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int GetHuanJingBaseIdList(int j) { int o = __offset(12); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int HuanJingBaseIdListLength { get { int o = __offset(12); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_HuanJingEquip> CreateFB_HuanJingEquip(FlatBufferBuilder builder,
      int ID = 0,
      StringOffset TitleEquip = default(StringOffset),
      StringOffset TitleEquipInfo = default(StringOffset),
      int Quality = -1,
      VectorOffset HuanJingBaseIdList = default(VectorOffset)) {
    builder.StartObject(5);
    FB_HuanJingEquip.AddHuanJingBaseIdList(builder, HuanJingBaseIdList);
    FB_HuanJingEquip.AddQuality(builder, Quality);
    FB_HuanJingEquip.AddTitleEquipInfo(builder, TitleEquipInfo);
    FB_HuanJingEquip.AddTitleEquip(builder, TitleEquip);
    FB_HuanJingEquip.AddID(builder, ID);
    return FB_HuanJingEquip.EndFB_HuanJingEquip(builder);
  }

  public static void StartFB_HuanJingEquip(FlatBufferBuilder builder) { builder.StartObject(5); }
  public static void AddID(FlatBufferBuilder builder, int ID) { builder.AddInt(0, ID, 0); }
  public static void AddTitleEquip(FlatBufferBuilder builder, StringOffset TitleEquipOffset) { builder.AddOffset(1, TitleEquipOffset.Value, 0); }
  public static void AddTitleEquipInfo(FlatBufferBuilder builder, StringOffset TitleEquipInfoOffset) { builder.AddOffset(2, TitleEquipInfoOffset.Value, 0); }
  public static void AddQuality(FlatBufferBuilder builder, int Quality) { builder.AddInt(3, Quality, -1); }
  public static void AddHuanJingBaseIdList(FlatBufferBuilder builder, VectorOffset HuanJingBaseIdListOffset) { builder.AddOffset(4, HuanJingBaseIdListOffset.Value, 0); }
  public static VectorOffset CreateHuanJingBaseIdListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartHuanJingBaseIdListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_HuanJingEquip> EndFB_HuanJingEquip(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_HuanJingEquip>(o);
  }
};

public sealed class FB_HuanJingEquipContainer : Table {
  public static FB_HuanJingEquipContainer GetRootAsFB_HuanJingEquipContainer(ByteBuffer _bb) { return GetRootAsFB_HuanJingEquipContainer(_bb, new FB_HuanJingEquipContainer()); }
  public static FB_HuanJingEquipContainer GetRootAsFB_HuanJingEquipContainer(ByteBuffer _bb, FB_HuanJingEquipContainer obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public static bool FB_HuanJingEquipContainerBufferHasIdentifier(ByteBuffer _bb) { return __has_identifier(_bb, "swdt"); }
  public FB_HuanJingEquipContainer __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public FB_HuanJingEquip GetItems(int j) { return GetItems(new FB_HuanJingEquip(), j); }
  public FB_HuanJingEquip GetItems(FB_HuanJingEquip obj, int j) { int o = __offset(4); return o != 0 ? obj.__init(__indirect(__vector(o) + j * 4), bb) : null; }
  public int ItemsLength { get { int o = __offset(4); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_HuanJingEquipContainer> CreateFB_HuanJingEquipContainer(FlatBufferBuilder builder,
      VectorOffset items = default(VectorOffset)) {
    builder.StartObject(1);
    FB_HuanJingEquipContainer.AddItems(builder, items);
    return FB_HuanJingEquipContainer.EndFB_HuanJingEquipContainer(builder);
  }

  public static void StartFB_HuanJingEquipContainer(FlatBufferBuilder builder) { builder.StartObject(1); }
  public static void AddItems(FlatBufferBuilder builder, VectorOffset itemsOffset) { builder.AddOffset(0, itemsOffset.Value, 0); }
  public static VectorOffset CreateItemsVector(FlatBufferBuilder builder, Offset<FB_HuanJingEquip>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static void StartItemsVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_HuanJingEquipContainer> EndFB_HuanJingEquipContainer(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_HuanJingEquipContainer>(o);
  }
  public static void FinishFB_HuanJingEquipContainerBuffer(FlatBufferBuilder builder, Offset<FB_HuanJingEquipContainer> offset) { builder.Finish(offset.Value, "swdt"); }
};


}
