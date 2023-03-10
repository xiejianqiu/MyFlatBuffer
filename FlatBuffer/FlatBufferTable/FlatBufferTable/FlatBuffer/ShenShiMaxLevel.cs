// automatically generated, do not modify

namespace Shark
{

using FlatBuffers;

public sealed class FB_ShenShiMaxLevel : Table {
  public static FB_ShenShiMaxLevel GetRootAsFB_ShenShiMaxLevel(ByteBuffer _bb) { return GetRootAsFB_ShenShiMaxLevel(_bb, new FB_ShenShiMaxLevel()); }
  public static FB_ShenShiMaxLevel GetRootAsFB_ShenShiMaxLevel(ByteBuffer _bb, FB_ShenShiMaxLevel obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public FB_ShenShiMaxLevel __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public int ID { get { int o = __offset(4); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int GetShenShiIdList(int j) { int o = __offset(6); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int ShenShiIdListLength { get { int o = __offset(6); return o != 0 ? __vector_len(o) : 0; } }
  public int GetShenShiMaxLevelList(int j) { int o = __offset(8); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int ShenShiMaxLevelListLength { get { int o = __offset(8); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_ShenShiMaxLevel> CreateFB_ShenShiMaxLevel(FlatBufferBuilder builder,
      int ID = 0,
      VectorOffset ShenShiIdList = default(VectorOffset),
      VectorOffset ShenShiMaxLevelList = default(VectorOffset)) {
    builder.StartObject(3);
    FB_ShenShiMaxLevel.AddShenShiMaxLevelList(builder, ShenShiMaxLevelList);
    FB_ShenShiMaxLevel.AddShenShiIdList(builder, ShenShiIdList);
    FB_ShenShiMaxLevel.AddID(builder, ID);
    return FB_ShenShiMaxLevel.EndFB_ShenShiMaxLevel(builder);
  }

  public static void StartFB_ShenShiMaxLevel(FlatBufferBuilder builder) { builder.StartObject(3); }
  public static void AddID(FlatBufferBuilder builder, int ID) { builder.AddInt(0, ID, 0); }
  public static void AddShenShiIdList(FlatBufferBuilder builder, VectorOffset ShenShiIdListOffset) { builder.AddOffset(1, ShenShiIdListOffset.Value, 0); }
  public static VectorOffset CreateShenShiIdListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartShenShiIdListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddShenShiMaxLevelList(FlatBufferBuilder builder, VectorOffset ShenShiMaxLevelListOffset) { builder.AddOffset(2, ShenShiMaxLevelListOffset.Value, 0); }
  public static VectorOffset CreateShenShiMaxLevelListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartShenShiMaxLevelListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_ShenShiMaxLevel> EndFB_ShenShiMaxLevel(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_ShenShiMaxLevel>(o);
  }
};

public sealed class FB_ShenShiMaxLevelContainer : Table {
  public static FB_ShenShiMaxLevelContainer GetRootAsFB_ShenShiMaxLevelContainer(ByteBuffer _bb) { return GetRootAsFB_ShenShiMaxLevelContainer(_bb, new FB_ShenShiMaxLevelContainer()); }
  public static FB_ShenShiMaxLevelContainer GetRootAsFB_ShenShiMaxLevelContainer(ByteBuffer _bb, FB_ShenShiMaxLevelContainer obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public static bool FB_ShenShiMaxLevelContainerBufferHasIdentifier(ByteBuffer _bb) { return __has_identifier(_bb, "swdt"); }
  public FB_ShenShiMaxLevelContainer __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public FB_ShenShiMaxLevel GetItems(int j) { return GetItems(new FB_ShenShiMaxLevel(), j); }
  public FB_ShenShiMaxLevel GetItems(FB_ShenShiMaxLevel obj, int j) { int o = __offset(4); return o != 0 ? obj.__init(__indirect(__vector(o) + j * 4), bb) : null; }
  public int ItemsLength { get { int o = __offset(4); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_ShenShiMaxLevelContainer> CreateFB_ShenShiMaxLevelContainer(FlatBufferBuilder builder,
      VectorOffset items = default(VectorOffset)) {
    builder.StartObject(1);
    FB_ShenShiMaxLevelContainer.AddItems(builder, items);
    return FB_ShenShiMaxLevelContainer.EndFB_ShenShiMaxLevelContainer(builder);
  }

  public static void StartFB_ShenShiMaxLevelContainer(FlatBufferBuilder builder) { builder.StartObject(1); }
  public static void AddItems(FlatBufferBuilder builder, VectorOffset itemsOffset) { builder.AddOffset(0, itemsOffset.Value, 0); }
  public static VectorOffset CreateItemsVector(FlatBufferBuilder builder, Offset<FB_ShenShiMaxLevel>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static void StartItemsVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_ShenShiMaxLevelContainer> EndFB_ShenShiMaxLevelContainer(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_ShenShiMaxLevelContainer>(o);
  }
  public static void FinishFB_ShenShiMaxLevelContainerBuffer(FlatBufferBuilder builder, Offset<FB_ShenShiMaxLevelContainer> offset) { builder.Finish(offset.Value, "swdt"); }
};


}
