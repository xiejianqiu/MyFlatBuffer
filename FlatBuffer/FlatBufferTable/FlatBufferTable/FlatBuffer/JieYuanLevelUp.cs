// automatically generated, do not modify

namespace Shark
{

using FlatBuffers;

public sealed class FB_JieYuanLevelUp : Table {
  public static FB_JieYuanLevelUp GetRootAsFB_JieYuanLevelUp(ByteBuffer _bb) { return GetRootAsFB_JieYuanLevelUp(_bb, new FB_JieYuanLevelUp()); }
  public static FB_JieYuanLevelUp GetRootAsFB_JieYuanLevelUp(ByteBuffer _bb, FB_JieYuanLevelUp obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public FB_JieYuanLevelUp __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public int Id { get { int o = __offset(4); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int ExpByTime { get { int o = __offset(6); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int ExpNeed { get { int o = __offset(8); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int GetAttrIdList(int j) { int o = __offset(10); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int AttrIdListLength { get { int o = __offset(10); return o != 0 ? __vector_len(o) : 0; } }
  public int GetAttrValueList(int j) { int o = __offset(12); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int AttrValueListLength { get { int o = __offset(12); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_JieYuanLevelUp> CreateFB_JieYuanLevelUp(FlatBufferBuilder builder,
      int Id = 0,
      int ExpByTime = 0,
      int ExpNeed = 0,
      VectorOffset AttrIdList = default(VectorOffset),
      VectorOffset AttrValueList = default(VectorOffset)) {
    builder.StartObject(5);
    FB_JieYuanLevelUp.AddAttrValueList(builder, AttrValueList);
    FB_JieYuanLevelUp.AddAttrIdList(builder, AttrIdList);
    FB_JieYuanLevelUp.AddExpNeed(builder, ExpNeed);
    FB_JieYuanLevelUp.AddExpByTime(builder, ExpByTime);
    FB_JieYuanLevelUp.AddId(builder, Id);
    return FB_JieYuanLevelUp.EndFB_JieYuanLevelUp(builder);
  }

  public static void StartFB_JieYuanLevelUp(FlatBufferBuilder builder) { builder.StartObject(5); }
  public static void AddId(FlatBufferBuilder builder, int Id) { builder.AddInt(0, Id, 0); }
  public static void AddExpByTime(FlatBufferBuilder builder, int ExpByTime) { builder.AddInt(1, ExpByTime, 0); }
  public static void AddExpNeed(FlatBufferBuilder builder, int ExpNeed) { builder.AddInt(2, ExpNeed, 0); }
  public static void AddAttrIdList(FlatBufferBuilder builder, VectorOffset AttrIdListOffset) { builder.AddOffset(3, AttrIdListOffset.Value, 0); }
  public static VectorOffset CreateAttrIdListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartAttrIdListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddAttrValueList(FlatBufferBuilder builder, VectorOffset AttrValueListOffset) { builder.AddOffset(4, AttrValueListOffset.Value, 0); }
  public static VectorOffset CreateAttrValueListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartAttrValueListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_JieYuanLevelUp> EndFB_JieYuanLevelUp(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_JieYuanLevelUp>(o);
  }
};

public sealed class FB_JieYuanLevelUpContainer : Table {
  public static FB_JieYuanLevelUpContainer GetRootAsFB_JieYuanLevelUpContainer(ByteBuffer _bb) { return GetRootAsFB_JieYuanLevelUpContainer(_bb, new FB_JieYuanLevelUpContainer()); }
  public static FB_JieYuanLevelUpContainer GetRootAsFB_JieYuanLevelUpContainer(ByteBuffer _bb, FB_JieYuanLevelUpContainer obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public static bool FB_JieYuanLevelUpContainerBufferHasIdentifier(ByteBuffer _bb) { return __has_identifier(_bb, "swdt"); }
  public FB_JieYuanLevelUpContainer __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public FB_JieYuanLevelUp GetItems(int j) { return GetItems(new FB_JieYuanLevelUp(), j); }
  public FB_JieYuanLevelUp GetItems(FB_JieYuanLevelUp obj, int j) { int o = __offset(4); return o != 0 ? obj.__init(__indirect(__vector(o) + j * 4), bb) : null; }
  public int ItemsLength { get { int o = __offset(4); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_JieYuanLevelUpContainer> CreateFB_JieYuanLevelUpContainer(FlatBufferBuilder builder,
      VectorOffset items = default(VectorOffset)) {
    builder.StartObject(1);
    FB_JieYuanLevelUpContainer.AddItems(builder, items);
    return FB_JieYuanLevelUpContainer.EndFB_JieYuanLevelUpContainer(builder);
  }

  public static void StartFB_JieYuanLevelUpContainer(FlatBufferBuilder builder) { builder.StartObject(1); }
  public static void AddItems(FlatBufferBuilder builder, VectorOffset itemsOffset) { builder.AddOffset(0, itemsOffset.Value, 0); }
  public static VectorOffset CreateItemsVector(FlatBufferBuilder builder, Offset<FB_JieYuanLevelUp>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static void StartItemsVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_JieYuanLevelUpContainer> EndFB_JieYuanLevelUpContainer(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_JieYuanLevelUpContainer>(o);
  }
  public static void FinishFB_JieYuanLevelUpContainerBuffer(FlatBufferBuilder builder, Offset<FB_JieYuanLevelUpContainer> offset) { builder.Finish(offset.Value, "swdt"); }
};


}
