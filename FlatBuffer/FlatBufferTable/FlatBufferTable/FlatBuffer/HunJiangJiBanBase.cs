// automatically generated, do not modify

namespace Shark
{

using FlatBuffers;

public sealed class FB_HunJiangJiBanBase : Table {
  public static FB_HunJiangJiBanBase GetRootAsFB_HunJiangJiBanBase(ByteBuffer _bb) { return GetRootAsFB_HunJiangJiBanBase(_bb, new FB_HunJiangJiBanBase()); }
  public static FB_HunJiangJiBanBase GetRootAsFB_HunJiangJiBanBase(ByteBuffer _bb, FB_HunJiangJiBanBase obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public FB_HunJiangJiBanBase __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public int ID { get { int o = __offset(4); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public string Name { get { int o = __offset(6); return o != 0 ? __string(o + bb_pos) : null; } }
  public int Quality { get { int o = __offset(8); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int GetSkillIDList(int j) { int o = __offset(10); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int SkillIDListLength { get { int o = __offset(10); return o != 0 ? __vector_len(o) : 0; } }
  public int GetHunJiangIDList(int j) { int o = __offset(12); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int HunJiangIDListLength { get { int o = __offset(12); return o != 0 ? __vector_len(o) : 0; } }
  public int GetShangZhenAttrIdList(int j) { int o = __offset(14); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int ShangZhenAttrIdListLength { get { int o = __offset(14); return o != 0 ? __vector_len(o) : 0; } }
  public int GetShangZhenAttrValList(int j) { int o = __offset(16); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int ShangZhenAttrValListLength { get { int o = __offset(16); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_HunJiangJiBanBase> CreateFB_HunJiangJiBanBase(FlatBufferBuilder builder,
      int ID = 0,
      StringOffset Name = default(StringOffset),
      int Quality = -1,
      VectorOffset SkillIDList = default(VectorOffset),
      VectorOffset HunJiangIDList = default(VectorOffset),
      VectorOffset ShangZhenAttrIdList = default(VectorOffset),
      VectorOffset ShangZhenAttrValList = default(VectorOffset)) {
    builder.StartObject(7);
    FB_HunJiangJiBanBase.AddShangZhenAttrValList(builder, ShangZhenAttrValList);
    FB_HunJiangJiBanBase.AddShangZhenAttrIdList(builder, ShangZhenAttrIdList);
    FB_HunJiangJiBanBase.AddHunJiangIDList(builder, HunJiangIDList);
    FB_HunJiangJiBanBase.AddSkillIDList(builder, SkillIDList);
    FB_HunJiangJiBanBase.AddQuality(builder, Quality);
    FB_HunJiangJiBanBase.AddName(builder, Name);
    FB_HunJiangJiBanBase.AddID(builder, ID);
    return FB_HunJiangJiBanBase.EndFB_HunJiangJiBanBase(builder);
  }

  public static void StartFB_HunJiangJiBanBase(FlatBufferBuilder builder) { builder.StartObject(7); }
  public static void AddID(FlatBufferBuilder builder, int ID) { builder.AddInt(0, ID, 0); }
  public static void AddName(FlatBufferBuilder builder, StringOffset NameOffset) { builder.AddOffset(1, NameOffset.Value, 0); }
  public static void AddQuality(FlatBufferBuilder builder, int Quality) { builder.AddInt(2, Quality, -1); }
  public static void AddSkillIDList(FlatBufferBuilder builder, VectorOffset SkillIDListOffset) { builder.AddOffset(3, SkillIDListOffset.Value, 0); }
  public static VectorOffset CreateSkillIDListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartSkillIDListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddHunJiangIDList(FlatBufferBuilder builder, VectorOffset HunJiangIDListOffset) { builder.AddOffset(4, HunJiangIDListOffset.Value, 0); }
  public static VectorOffset CreateHunJiangIDListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartHunJiangIDListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddShangZhenAttrIdList(FlatBufferBuilder builder, VectorOffset ShangZhenAttrIdListOffset) { builder.AddOffset(5, ShangZhenAttrIdListOffset.Value, 0); }
  public static VectorOffset CreateShangZhenAttrIdListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartShangZhenAttrIdListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddShangZhenAttrValList(FlatBufferBuilder builder, VectorOffset ShangZhenAttrValListOffset) { builder.AddOffset(6, ShangZhenAttrValListOffset.Value, 0); }
  public static VectorOffset CreateShangZhenAttrValListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartShangZhenAttrValListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_HunJiangJiBanBase> EndFB_HunJiangJiBanBase(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_HunJiangJiBanBase>(o);
  }
};

public sealed class FB_HunJiangJiBanBaseContainer : Table {
  public static FB_HunJiangJiBanBaseContainer GetRootAsFB_HunJiangJiBanBaseContainer(ByteBuffer _bb) { return GetRootAsFB_HunJiangJiBanBaseContainer(_bb, new FB_HunJiangJiBanBaseContainer()); }
  public static FB_HunJiangJiBanBaseContainer GetRootAsFB_HunJiangJiBanBaseContainer(ByteBuffer _bb, FB_HunJiangJiBanBaseContainer obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public static bool FB_HunJiangJiBanBaseContainerBufferHasIdentifier(ByteBuffer _bb) { return __has_identifier(_bb, "swdt"); }
  public FB_HunJiangJiBanBaseContainer __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public FB_HunJiangJiBanBase GetItems(int j) { return GetItems(new FB_HunJiangJiBanBase(), j); }
  public FB_HunJiangJiBanBase GetItems(FB_HunJiangJiBanBase obj, int j) { int o = __offset(4); return o != 0 ? obj.__init(__indirect(__vector(o) + j * 4), bb) : null; }
  public int ItemsLength { get { int o = __offset(4); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_HunJiangJiBanBaseContainer> CreateFB_HunJiangJiBanBaseContainer(FlatBufferBuilder builder,
      VectorOffset items = default(VectorOffset)) {
    builder.StartObject(1);
    FB_HunJiangJiBanBaseContainer.AddItems(builder, items);
    return FB_HunJiangJiBanBaseContainer.EndFB_HunJiangJiBanBaseContainer(builder);
  }

  public static void StartFB_HunJiangJiBanBaseContainer(FlatBufferBuilder builder) { builder.StartObject(1); }
  public static void AddItems(FlatBufferBuilder builder, VectorOffset itemsOffset) { builder.AddOffset(0, itemsOffset.Value, 0); }
  public static VectorOffset CreateItemsVector(FlatBufferBuilder builder, Offset<FB_HunJiangJiBanBase>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static void StartItemsVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_HunJiangJiBanBaseContainer> EndFB_HunJiangJiBanBaseContainer(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_HunJiangJiBanBaseContainer>(o);
  }
  public static void FinishFB_HunJiangJiBanBaseContainerBuffer(FlatBufferBuilder builder, Offset<FB_HunJiangJiBanBaseContainer> offset) { builder.Finish(offset.Value, "swdt"); }
};


}
