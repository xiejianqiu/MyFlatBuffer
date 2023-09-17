// automatically generated, do not modify

namespace Shark
{

using FlatBuffers;

public sealed class FB_DiamondSet : Table {
  public static FB_DiamondSet GetRootAsFB_DiamondSet(ByteBuffer _bb) { return GetRootAsFB_DiamondSet(_bb, new FB_DiamondSet()); }
  public static FB_DiamondSet GetRootAsFB_DiamondSet(ByteBuffer _bb, FB_DiamondSet obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public FB_DiamondSet __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public int Id { get { int o = __offset(4); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int SlotNum { get { int o = __offset(6); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int GetSlotTypeList(int j) { int o = __offset(8); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int SlotTypeListLength { get { int o = __offset(8); return o != 0 ? __vector_len(o) : 0; } }
  public int GetUnlockGodWordLevelList(int j) { int o = __offset(10); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int UnlockGodWordLevelListLength { get { int o = __offset(10); return o != 0 ? __vector_len(o) : 0; } }
  public int UnlockGodVIPLevel { get { int o = __offset(12); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int UnlockGodVIP7Level { get { int o = __offset(14); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int GetShenZhuangUnLockLevelList(int j) { int o = __offset(16); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int ShenZhuangUnLockLevelListLength { get { int o = __offset(16); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_DiamondSet> CreateFB_DiamondSet(FlatBufferBuilder builder,
      int Id = 0,
      int SlotNum = -1,
      VectorOffset SlotTypeList = default(VectorOffset),
      VectorOffset UnlockGodWordLevelList = default(VectorOffset),
      int UnlockGodVIPLevel = -1,
      int UnlockGodVIP7Level = -1,
      VectorOffset ShenZhuangUnLockLevelList = default(VectorOffset)) {
    builder.StartObject(7);
    FB_DiamondSet.AddShenZhuangUnLockLevelList(builder, ShenZhuangUnLockLevelList);
    FB_DiamondSet.AddUnlockGodVIP7Level(builder, UnlockGodVIP7Level);
    FB_DiamondSet.AddUnlockGodVIPLevel(builder, UnlockGodVIPLevel);
    FB_DiamondSet.AddUnlockGodWordLevelList(builder, UnlockGodWordLevelList);
    FB_DiamondSet.AddSlotTypeList(builder, SlotTypeList);
    FB_DiamondSet.AddSlotNum(builder, SlotNum);
    FB_DiamondSet.AddId(builder, Id);
    return FB_DiamondSet.EndFB_DiamondSet(builder);
  }

  public static void StartFB_DiamondSet(FlatBufferBuilder builder) { builder.StartObject(7); }
  public static void AddId(FlatBufferBuilder builder, int Id) { builder.AddInt(0, Id, 0); }
  public static void AddSlotNum(FlatBufferBuilder builder, int SlotNum) { builder.AddInt(1, SlotNum, -1); }
  public static void AddSlotTypeList(FlatBufferBuilder builder, VectorOffset SlotTypeListOffset) { builder.AddOffset(2, SlotTypeListOffset.Value, 0); }
  public static VectorOffset CreateSlotTypeListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartSlotTypeListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddUnlockGodWordLevelList(FlatBufferBuilder builder, VectorOffset UnlockGodWordLevelListOffset) { builder.AddOffset(3, UnlockGodWordLevelListOffset.Value, 0); }
  public static VectorOffset CreateUnlockGodWordLevelListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartUnlockGodWordLevelListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddUnlockGodVIPLevel(FlatBufferBuilder builder, int UnlockGodVIPLevel) { builder.AddInt(4, UnlockGodVIPLevel, -1); }
  public static void AddUnlockGodVIP7Level(FlatBufferBuilder builder, int UnlockGodVIP7Level) { builder.AddInt(5, UnlockGodVIP7Level, -1); }
  public static void AddShenZhuangUnLockLevelList(FlatBufferBuilder builder, VectorOffset ShenZhuangUnLockLevelListOffset) { builder.AddOffset(6, ShenZhuangUnLockLevelListOffset.Value, 0); }
  public static VectorOffset CreateShenZhuangUnLockLevelListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartShenZhuangUnLockLevelListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_DiamondSet> EndFB_DiamondSet(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_DiamondSet>(o);
  }
};

public sealed class FB_DiamondSetContainer : Table {
  public static FB_DiamondSetContainer GetRootAsFB_DiamondSetContainer(ByteBuffer _bb) { return GetRootAsFB_DiamondSetContainer(_bb, new FB_DiamondSetContainer()); }
  public static FB_DiamondSetContainer GetRootAsFB_DiamondSetContainer(ByteBuffer _bb, FB_DiamondSetContainer obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public static bool FB_DiamondSetContainerBufferHasIdentifier(ByteBuffer _bb) { return __has_identifier(_bb, "swdt"); }
  public FB_DiamondSetContainer __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public FB_DiamondSet GetItems(int j) { return GetItems(new FB_DiamondSet(), j); }
  public FB_DiamondSet GetItems(FB_DiamondSet obj, int j) { int o = __offset(4); return o != 0 ? obj.__init(__indirect(__vector(o) + j * 4), bb) : null; }
  public int ItemsLength { get { int o = __offset(4); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_DiamondSetContainer> CreateFB_DiamondSetContainer(FlatBufferBuilder builder,
      VectorOffset items = default(VectorOffset)) {
    builder.StartObject(1);
    FB_DiamondSetContainer.AddItems(builder, items);
    return FB_DiamondSetContainer.EndFB_DiamondSetContainer(builder);
  }

  public static void StartFB_DiamondSetContainer(FlatBufferBuilder builder) { builder.StartObject(1); }
  public static void AddItems(FlatBufferBuilder builder, VectorOffset itemsOffset) { builder.AddOffset(0, itemsOffset.Value, 0); }
  public static VectorOffset CreateItemsVector(FlatBufferBuilder builder, Offset<FB_DiamondSet>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static void StartItemsVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_DiamondSetContainer> EndFB_DiamondSetContainer(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_DiamondSetContainer>(o);
  }
  public static void FinishFB_DiamondSetContainerBuffer(FlatBufferBuilder builder, Offset<FB_DiamondSetContainer> offset) { builder.Finish(offset.Value, "swdt"); }
};


}
