// automatically generated, do not modify

namespace Shark
{

using FlatBuffers;

public sealed class FB_baiwanjijie : Table {
  public static FB_baiwanjijie GetRootAsFB_baiwanjijie(ByteBuffer _bb) { return GetRootAsFB_baiwanjijie(_bb, new FB_baiwanjijie()); }
  public static FB_baiwanjijie GetRootAsFB_baiwanjijie(ByteBuffer _bb, FB_baiwanjijie obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public FB_baiwanjijie __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public int ID { get { int o = __offset(4); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int ResPath { get { int o = __offset(6); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int GetItemIdList(int j) { int o = __offset(8); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int ItemIdListLength { get { int o = __offset(8); return o != 0 ? __vector_len(o) : 0; } }
  public int GetMaxIiemList(int j) { int o = __offset(10); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int MaxIiemListLength { get { int o = __offset(10); return o != 0 ? __vector_len(o) : 0; } }
  public string GetNameIdList(int j) { int o = __offset(12); return o != 0 ? __string(__vector(o) + j * 4) : null; }
  public int NameIdListLength { get { int o = __offset(12); return o != 0 ? __vector_len(o) : 0; } }
  public int GetUiInfoIdList(int j) { int o = __offset(14); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int UiInfoIdListLength { get { int o = __offset(14); return o != 0 ? __vector_len(o) : 0; } }
  public int GetParamIdList(int j) { int o = __offset(16); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int ParamIdListLength { get { int o = __offset(16); return o != 0 ? __vector_len(o) : 0; } }
  public int Combat { get { int o = __offset(18); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int ParmSec { get { int o = __offset(20); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }

  public static Offset<FB_baiwanjijie> CreateFB_baiwanjijie(FlatBufferBuilder builder,
      int ID = 0,
      int ResPath = 0,
      VectorOffset ItemIdList = default(VectorOffset),
      VectorOffset MaxIiemList = default(VectorOffset),
      VectorOffset NameIdList = default(VectorOffset),
      VectorOffset UiInfoIdList = default(VectorOffset),
      VectorOffset ParamIdList = default(VectorOffset),
      int Combat = -1,
      int ParmSec = -1) {
    builder.StartObject(9);
    FB_baiwanjijie.AddParmSec(builder, ParmSec);
    FB_baiwanjijie.AddCombat(builder, Combat);
    FB_baiwanjijie.AddParamIdList(builder, ParamIdList);
    FB_baiwanjijie.AddUiInfoIdList(builder, UiInfoIdList);
    FB_baiwanjijie.AddNameIdList(builder, NameIdList);
    FB_baiwanjijie.AddMaxIiemList(builder, MaxIiemList);
    FB_baiwanjijie.AddItemIdList(builder, ItemIdList);
    FB_baiwanjijie.AddResPath(builder, ResPath);
    FB_baiwanjijie.AddID(builder, ID);
    return FB_baiwanjijie.EndFB_baiwanjijie(builder);
  }

  public static void StartFB_baiwanjijie(FlatBufferBuilder builder) { builder.StartObject(9); }
  public static void AddID(FlatBufferBuilder builder, int ID) { builder.AddInt(0, ID, 0); }
  public static void AddResPath(FlatBufferBuilder builder, int ResPath) { builder.AddInt(1, ResPath, 0); }
  public static void AddItemIdList(FlatBufferBuilder builder, VectorOffset ItemIdListOffset) { builder.AddOffset(2, ItemIdListOffset.Value, 0); }
  public static VectorOffset CreateItemIdListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartItemIdListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddMaxIiemList(FlatBufferBuilder builder, VectorOffset MaxIiemListOffset) { builder.AddOffset(3, MaxIiemListOffset.Value, 0); }
  public static VectorOffset CreateMaxIiemListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartMaxIiemListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddNameIdList(FlatBufferBuilder builder, VectorOffset NameIdListOffset) { builder.AddOffset(4, NameIdListOffset.Value, 0); }
  public static VectorOffset CreateNameIdListVector(FlatBufferBuilder builder, StringOffset[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static void StartNameIdListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddUiInfoIdList(FlatBufferBuilder builder, VectorOffset UiInfoIdListOffset) { builder.AddOffset(5, UiInfoIdListOffset.Value, 0); }
  public static VectorOffset CreateUiInfoIdListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartUiInfoIdListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddParamIdList(FlatBufferBuilder builder, VectorOffset ParamIdListOffset) { builder.AddOffset(6, ParamIdListOffset.Value, 0); }
  public static VectorOffset CreateParamIdListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartParamIdListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddCombat(FlatBufferBuilder builder, int Combat) { builder.AddInt(7, Combat, -1); }
  public static void AddParmSec(FlatBufferBuilder builder, int ParmSec) { builder.AddInt(8, ParmSec, -1); }
  public static Offset<FB_baiwanjijie> EndFB_baiwanjijie(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_baiwanjijie>(o);
  }
};

public sealed class FB_baiwanjijieContainer : Table {
  public static FB_baiwanjijieContainer GetRootAsFB_baiwanjijieContainer(ByteBuffer _bb) { return GetRootAsFB_baiwanjijieContainer(_bb, new FB_baiwanjijieContainer()); }
  public static FB_baiwanjijieContainer GetRootAsFB_baiwanjijieContainer(ByteBuffer _bb, FB_baiwanjijieContainer obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public static bool FB_baiwanjijieContainerBufferHasIdentifier(ByteBuffer _bb) { return __has_identifier(_bb, "swdt"); }
  public FB_baiwanjijieContainer __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public FB_baiwanjijie GetItems(int j) { return GetItems(new FB_baiwanjijie(), j); }
  public FB_baiwanjijie GetItems(FB_baiwanjijie obj, int j) { int o = __offset(4); return o != 0 ? obj.__init(__indirect(__vector(o) + j * 4), bb) : null; }
  public int ItemsLength { get { int o = __offset(4); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_baiwanjijieContainer> CreateFB_baiwanjijieContainer(FlatBufferBuilder builder,
      VectorOffset items = default(VectorOffset)) {
    builder.StartObject(1);
    FB_baiwanjijieContainer.AddItems(builder, items);
    return FB_baiwanjijieContainer.EndFB_baiwanjijieContainer(builder);
  }

  public static void StartFB_baiwanjijieContainer(FlatBufferBuilder builder) { builder.StartObject(1); }
  public static void AddItems(FlatBufferBuilder builder, VectorOffset itemsOffset) { builder.AddOffset(0, itemsOffset.Value, 0); }
  public static VectorOffset CreateItemsVector(FlatBufferBuilder builder, Offset<FB_baiwanjijie>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static void StartItemsVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_baiwanjijieContainer> EndFB_baiwanjijieContainer(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_baiwanjijieContainer>(o);
  }
  public static void FinishFB_baiwanjijieContainerBuffer(FlatBufferBuilder builder, Offset<FB_baiwanjijieContainer> offset) { builder.Finish(offset.Value, "swdt"); }
};


}
