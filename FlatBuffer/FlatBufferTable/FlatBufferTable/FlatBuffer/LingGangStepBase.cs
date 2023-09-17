// automatically generated, do not modify

namespace Shark
{

using FlatBuffers;

public sealed class FB_LingGangStepBase : Table {
  public static FB_LingGangStepBase GetRootAsFB_LingGangStepBase(ByteBuffer _bb) { return GetRootAsFB_LingGangStepBase(_bb, new FB_LingGangStepBase()); }
  public static FB_LingGangStepBase GetRootAsFB_LingGangStepBase(ByteBuffer _bb, FB_LingGangStepBase obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public FB_LingGangStepBase __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public int Id { get { int o = __offset(4); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int Star { get { int o = __offset(6); return o != 0 ? bb.GetInt(o + bb_pos) : (int)1; } }
  public int Step { get { int o = __offset(8); return o != 0 ? bb.GetInt(o + bb_pos) : (int)1; } }
  public int Exp { get { int o = __offset(10); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int UnLockLevel { get { int o = __offset(12); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int UnLockItem { get { int o = __offset(14); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int UnLockItemNum { get { int o = __offset(16); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int GetAttrIdList(int j) { int o = __offset(18); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int AttrIdListLength { get { int o = __offset(18); return o != 0 ? __vector_len(o) : 0; } }
  public int GetAttrValueList(int j) { int o = __offset(20); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int AttrValueListLength { get { int o = __offset(20); return o != 0 ? __vector_len(o) : 0; } }
  public int FakeObjId { get { int o = __offset(22); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int EffectId { get { int o = __offset(24); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int JianKeEffectId { get { int o = __offset(26); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }

  public static Offset<FB_LingGangStepBase> CreateFB_LingGangStepBase(FlatBufferBuilder builder,
      int Id = 0,
      int Star = 1,
      int Step = 1,
      int Exp = -1,
      int UnLockLevel = -1,
      int UnLockItem = -1,
      int UnLockItemNum = -1,
      VectorOffset AttrIdList = default(VectorOffset),
      VectorOffset AttrValueList = default(VectorOffset),
      int FakeObjId = -1,
      int EffectId = -1,
      int JianKeEffectId = -1) {
    builder.StartObject(12);
    FB_LingGangStepBase.AddJianKeEffectId(builder, JianKeEffectId);
    FB_LingGangStepBase.AddEffectId(builder, EffectId);
    FB_LingGangStepBase.AddFakeObjId(builder, FakeObjId);
    FB_LingGangStepBase.AddAttrValueList(builder, AttrValueList);
    FB_LingGangStepBase.AddAttrIdList(builder, AttrIdList);
    FB_LingGangStepBase.AddUnLockItemNum(builder, UnLockItemNum);
    FB_LingGangStepBase.AddUnLockItem(builder, UnLockItem);
    FB_LingGangStepBase.AddUnLockLevel(builder, UnLockLevel);
    FB_LingGangStepBase.AddExp(builder, Exp);
    FB_LingGangStepBase.AddStep(builder, Step);
    FB_LingGangStepBase.AddStar(builder, Star);
    FB_LingGangStepBase.AddId(builder, Id);
    return FB_LingGangStepBase.EndFB_LingGangStepBase(builder);
  }

  public static void StartFB_LingGangStepBase(FlatBufferBuilder builder) { builder.StartObject(12); }
  public static void AddId(FlatBufferBuilder builder, int Id) { builder.AddInt(0, Id, 0); }
  public static void AddStar(FlatBufferBuilder builder, int Star) { builder.AddInt(1, Star, 1); }
  public static void AddStep(FlatBufferBuilder builder, int Step) { builder.AddInt(2, Step, 1); }
  public static void AddExp(FlatBufferBuilder builder, int Exp) { builder.AddInt(3, Exp, -1); }
  public static void AddUnLockLevel(FlatBufferBuilder builder, int UnLockLevel) { builder.AddInt(4, UnLockLevel, -1); }
  public static void AddUnLockItem(FlatBufferBuilder builder, int UnLockItem) { builder.AddInt(5, UnLockItem, -1); }
  public static void AddUnLockItemNum(FlatBufferBuilder builder, int UnLockItemNum) { builder.AddInt(6, UnLockItemNum, -1); }
  public static void AddAttrIdList(FlatBufferBuilder builder, VectorOffset AttrIdListOffset) { builder.AddOffset(7, AttrIdListOffset.Value, 0); }
  public static VectorOffset CreateAttrIdListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartAttrIdListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddAttrValueList(FlatBufferBuilder builder, VectorOffset AttrValueListOffset) { builder.AddOffset(8, AttrValueListOffset.Value, 0); }
  public static VectorOffset CreateAttrValueListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartAttrValueListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddFakeObjId(FlatBufferBuilder builder, int FakeObjId) { builder.AddInt(9, FakeObjId, -1); }
  public static void AddEffectId(FlatBufferBuilder builder, int EffectId) { builder.AddInt(10, EffectId, -1); }
  public static void AddJianKeEffectId(FlatBufferBuilder builder, int JianKeEffectId) { builder.AddInt(11, JianKeEffectId, -1); }
  public static Offset<FB_LingGangStepBase> EndFB_LingGangStepBase(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_LingGangStepBase>(o);
  }
};

public sealed class FB_LingGangStepBaseContainer : Table {
  public static FB_LingGangStepBaseContainer GetRootAsFB_LingGangStepBaseContainer(ByteBuffer _bb) { return GetRootAsFB_LingGangStepBaseContainer(_bb, new FB_LingGangStepBaseContainer()); }
  public static FB_LingGangStepBaseContainer GetRootAsFB_LingGangStepBaseContainer(ByteBuffer _bb, FB_LingGangStepBaseContainer obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public static bool FB_LingGangStepBaseContainerBufferHasIdentifier(ByteBuffer _bb) { return __has_identifier(_bb, "swdt"); }
  public FB_LingGangStepBaseContainer __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public FB_LingGangStepBase GetItems(int j) { return GetItems(new FB_LingGangStepBase(), j); }
  public FB_LingGangStepBase GetItems(FB_LingGangStepBase obj, int j) { int o = __offset(4); return o != 0 ? obj.__init(__indirect(__vector(o) + j * 4), bb) : null; }
  public int ItemsLength { get { int o = __offset(4); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_LingGangStepBaseContainer> CreateFB_LingGangStepBaseContainer(FlatBufferBuilder builder,
      VectorOffset items = default(VectorOffset)) {
    builder.StartObject(1);
    FB_LingGangStepBaseContainer.AddItems(builder, items);
    return FB_LingGangStepBaseContainer.EndFB_LingGangStepBaseContainer(builder);
  }

  public static void StartFB_LingGangStepBaseContainer(FlatBufferBuilder builder) { builder.StartObject(1); }
  public static void AddItems(FlatBufferBuilder builder, VectorOffset itemsOffset) { builder.AddOffset(0, itemsOffset.Value, 0); }
  public static VectorOffset CreateItemsVector(FlatBufferBuilder builder, Offset<FB_LingGangStepBase>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static void StartItemsVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_LingGangStepBaseContainer> EndFB_LingGangStepBaseContainer(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_LingGangStepBaseContainer>(o);
  }
  public static void FinishFB_LingGangStepBaseContainerBuffer(FlatBufferBuilder builder, Offset<FB_LingGangStepBaseContainer> offset) { builder.Finish(offset.Value, "swdt"); }
};


}
