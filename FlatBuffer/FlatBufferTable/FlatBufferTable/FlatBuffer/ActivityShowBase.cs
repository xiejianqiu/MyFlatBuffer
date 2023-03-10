// automatically generated, do not modify

namespace Shark
{

using FlatBuffers;

public sealed class FB_ActivityShowBase : Table {
  public static FB_ActivityShowBase GetRootAsFB_ActivityShowBase(ByteBuffer _bb) { return GetRootAsFB_ActivityShowBase(_bb, new FB_ActivityShowBase()); }
  public static FB_ActivityShowBase GetRootAsFB_ActivityShowBase(ByteBuffer _bb, FB_ActivityShowBase obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public FB_ActivityShowBase __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public int ID { get { int o = __offset(4); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public string Name { get { int o = __offset(6); return o != 0 ? __string(o + bb_pos) : null; } }
  public int UnLockLevel { get { int o = __offset(8); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int GetEffectIDList(int j) { int o = __offset(10); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int EffectIDListLength { get { int o = __offset(10); return o != 0 ? __vector_len(o) : 0; } }
  public int FakeObjShowId { get { int o = __offset(12); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }

  public static Offset<FB_ActivityShowBase> CreateFB_ActivityShowBase(FlatBufferBuilder builder,
      int ID = 0,
      StringOffset Name = default(StringOffset),
      int UnLockLevel = -1,
      VectorOffset EffectIDList = default(VectorOffset),
      int FakeObjShowId = -1) {
    builder.StartObject(5);
    FB_ActivityShowBase.AddFakeObjShowId(builder, FakeObjShowId);
    FB_ActivityShowBase.AddEffectIDList(builder, EffectIDList);
    FB_ActivityShowBase.AddUnLockLevel(builder, UnLockLevel);
    FB_ActivityShowBase.AddName(builder, Name);
    FB_ActivityShowBase.AddID(builder, ID);
    return FB_ActivityShowBase.EndFB_ActivityShowBase(builder);
  }

  public static void StartFB_ActivityShowBase(FlatBufferBuilder builder) { builder.StartObject(5); }
  public static void AddID(FlatBufferBuilder builder, int ID) { builder.AddInt(0, ID, 0); }
  public static void AddName(FlatBufferBuilder builder, StringOffset NameOffset) { builder.AddOffset(1, NameOffset.Value, 0); }
  public static void AddUnLockLevel(FlatBufferBuilder builder, int UnLockLevel) { builder.AddInt(2, UnLockLevel, -1); }
  public static void AddEffectIDList(FlatBufferBuilder builder, VectorOffset EffectIDListOffset) { builder.AddOffset(3, EffectIDListOffset.Value, 0); }
  public static VectorOffset CreateEffectIDListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartEffectIDListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddFakeObjShowId(FlatBufferBuilder builder, int FakeObjShowId) { builder.AddInt(4, FakeObjShowId, -1); }
  public static Offset<FB_ActivityShowBase> EndFB_ActivityShowBase(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_ActivityShowBase>(o);
  }
};

public sealed class FB_ActivityShowBaseContainer : Table {
  public static FB_ActivityShowBaseContainer GetRootAsFB_ActivityShowBaseContainer(ByteBuffer _bb) { return GetRootAsFB_ActivityShowBaseContainer(_bb, new FB_ActivityShowBaseContainer()); }
  public static FB_ActivityShowBaseContainer GetRootAsFB_ActivityShowBaseContainer(ByteBuffer _bb, FB_ActivityShowBaseContainer obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public static bool FB_ActivityShowBaseContainerBufferHasIdentifier(ByteBuffer _bb) { return __has_identifier(_bb, "swdt"); }
  public FB_ActivityShowBaseContainer __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public FB_ActivityShowBase GetItems(int j) { return GetItems(new FB_ActivityShowBase(), j); }
  public FB_ActivityShowBase GetItems(FB_ActivityShowBase obj, int j) { int o = __offset(4); return o != 0 ? obj.__init(__indirect(__vector(o) + j * 4), bb) : null; }
  public int ItemsLength { get { int o = __offset(4); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_ActivityShowBaseContainer> CreateFB_ActivityShowBaseContainer(FlatBufferBuilder builder,
      VectorOffset items = default(VectorOffset)) {
    builder.StartObject(1);
    FB_ActivityShowBaseContainer.AddItems(builder, items);
    return FB_ActivityShowBaseContainer.EndFB_ActivityShowBaseContainer(builder);
  }

  public static void StartFB_ActivityShowBaseContainer(FlatBufferBuilder builder) { builder.StartObject(1); }
  public static void AddItems(FlatBufferBuilder builder, VectorOffset itemsOffset) { builder.AddOffset(0, itemsOffset.Value, 0); }
  public static VectorOffset CreateItemsVector(FlatBufferBuilder builder, Offset<FB_ActivityShowBase>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static void StartItemsVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_ActivityShowBaseContainer> EndFB_ActivityShowBaseContainer(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_ActivityShowBaseContainer>(o);
  }
  public static void FinishFB_ActivityShowBaseContainerBuffer(FlatBufferBuilder builder, Offset<FB_ActivityShowBaseContainer> offset) { builder.Finish(offset.Value, "swdt"); }
};


}
