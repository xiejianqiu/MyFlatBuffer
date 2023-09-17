// automatically generated, do not modify

namespace Shark
{

using FlatBuffers;

public sealed class FB_SYHTianXingBaoGe : Table {
  public static FB_SYHTianXingBaoGe GetRootAsFB_SYHTianXingBaoGe(ByteBuffer _bb) { return GetRootAsFB_SYHTianXingBaoGe(_bb, new FB_SYHTianXingBaoGe()); }
  public static FB_SYHTianXingBaoGe GetRootAsFB_SYHTianXingBaoGe(ByteBuffer _bb, FB_SYHTianXingBaoGe obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public FB_SYHTianXingBaoGe __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public int ID { get { int o = __offset(4); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int GetJianBaoCountList(int j) { int o = __offset(6); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int JianBaoCountListLength { get { int o = __offset(6); return o != 0 ? __vector_len(o) : 0; } }
  public int VipLimit { get { int o = __offset(8); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int GetVipCoefficientList(int j) { int o = __offset(10); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int VipCoefficientListLength { get { int o = __offset(10); return o != 0 ? __vector_len(o) : 0; } }
  public int AddNum { get { int o = __offset(12); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int HighDropBoxId { get { int o = __offset(14); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int LowDropBoxId { get { int o = __offset(16); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int ThreeDropBox { get { int o = __offset(18); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int LevelLimit { get { int o = __offset(20); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int Param { get { int o = __offset(22); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int GetItemIdList(int j) { int o = __offset(24); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int ItemIdListLength { get { int o = __offset(24); return o != 0 ? __vector_len(o) : 0; } }
  public int GetItemNumList(int j) { int o = __offset(26); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int ItemNumListLength { get { int o = __offset(26); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_SYHTianXingBaoGe> CreateFB_SYHTianXingBaoGe(FlatBufferBuilder builder,
      int ID = 0,
      VectorOffset JianBaoCountList = default(VectorOffset),
      int VipLimit = -1,
      VectorOffset VipCoefficientList = default(VectorOffset),
      int AddNum = -1,
      int HighDropBoxId = 0,
      int LowDropBoxId = 0,
      int ThreeDropBox = 0,
      int LevelLimit = 0,
      int Param = -1,
      VectorOffset ItemIdList = default(VectorOffset),
      VectorOffset ItemNumList = default(VectorOffset)) {
    builder.StartObject(12);
    FB_SYHTianXingBaoGe.AddItemNumList(builder, ItemNumList);
    FB_SYHTianXingBaoGe.AddItemIdList(builder, ItemIdList);
    FB_SYHTianXingBaoGe.AddParam(builder, Param);
    FB_SYHTianXingBaoGe.AddLevelLimit(builder, LevelLimit);
    FB_SYHTianXingBaoGe.AddThreeDropBox(builder, ThreeDropBox);
    FB_SYHTianXingBaoGe.AddLowDropBoxId(builder, LowDropBoxId);
    FB_SYHTianXingBaoGe.AddHighDropBoxId(builder, HighDropBoxId);
    FB_SYHTianXingBaoGe.AddAddNum(builder, AddNum);
    FB_SYHTianXingBaoGe.AddVipCoefficientList(builder, VipCoefficientList);
    FB_SYHTianXingBaoGe.AddVipLimit(builder, VipLimit);
    FB_SYHTianXingBaoGe.AddJianBaoCountList(builder, JianBaoCountList);
    FB_SYHTianXingBaoGe.AddID(builder, ID);
    return FB_SYHTianXingBaoGe.EndFB_SYHTianXingBaoGe(builder);
  }

  public static void StartFB_SYHTianXingBaoGe(FlatBufferBuilder builder) { builder.StartObject(12); }
  public static void AddID(FlatBufferBuilder builder, int ID) { builder.AddInt(0, ID, 0); }
  public static void AddJianBaoCountList(FlatBufferBuilder builder, VectorOffset JianBaoCountListOffset) { builder.AddOffset(1, JianBaoCountListOffset.Value, 0); }
  public static VectorOffset CreateJianBaoCountListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartJianBaoCountListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddVipLimit(FlatBufferBuilder builder, int VipLimit) { builder.AddInt(2, VipLimit, -1); }
  public static void AddVipCoefficientList(FlatBufferBuilder builder, VectorOffset VipCoefficientListOffset) { builder.AddOffset(3, VipCoefficientListOffset.Value, 0); }
  public static VectorOffset CreateVipCoefficientListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartVipCoefficientListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddAddNum(FlatBufferBuilder builder, int AddNum) { builder.AddInt(4, AddNum, -1); }
  public static void AddHighDropBoxId(FlatBufferBuilder builder, int HighDropBoxId) { builder.AddInt(5, HighDropBoxId, 0); }
  public static void AddLowDropBoxId(FlatBufferBuilder builder, int LowDropBoxId) { builder.AddInt(6, LowDropBoxId, 0); }
  public static void AddThreeDropBox(FlatBufferBuilder builder, int ThreeDropBox) { builder.AddInt(7, ThreeDropBox, 0); }
  public static void AddLevelLimit(FlatBufferBuilder builder, int LevelLimit) { builder.AddInt(8, LevelLimit, 0); }
  public static void AddParam(FlatBufferBuilder builder, int Param) { builder.AddInt(9, Param, -1); }
  public static void AddItemIdList(FlatBufferBuilder builder, VectorOffset ItemIdListOffset) { builder.AddOffset(10, ItemIdListOffset.Value, 0); }
  public static VectorOffset CreateItemIdListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartItemIdListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddItemNumList(FlatBufferBuilder builder, VectorOffset ItemNumListOffset) { builder.AddOffset(11, ItemNumListOffset.Value, 0); }
  public static VectorOffset CreateItemNumListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartItemNumListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_SYHTianXingBaoGe> EndFB_SYHTianXingBaoGe(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_SYHTianXingBaoGe>(o);
  }
};

public sealed class FB_SYHTianXingBaoGeContainer : Table {
  public static FB_SYHTianXingBaoGeContainer GetRootAsFB_SYHTianXingBaoGeContainer(ByteBuffer _bb) { return GetRootAsFB_SYHTianXingBaoGeContainer(_bb, new FB_SYHTianXingBaoGeContainer()); }
  public static FB_SYHTianXingBaoGeContainer GetRootAsFB_SYHTianXingBaoGeContainer(ByteBuffer _bb, FB_SYHTianXingBaoGeContainer obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public static bool FB_SYHTianXingBaoGeContainerBufferHasIdentifier(ByteBuffer _bb) { return __has_identifier(_bb, "swdt"); }
  public FB_SYHTianXingBaoGeContainer __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public FB_SYHTianXingBaoGe GetItems(int j) { return GetItems(new FB_SYHTianXingBaoGe(), j); }
  public FB_SYHTianXingBaoGe GetItems(FB_SYHTianXingBaoGe obj, int j) { int o = __offset(4); return o != 0 ? obj.__init(__indirect(__vector(o) + j * 4), bb) : null; }
  public int ItemsLength { get { int o = __offset(4); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_SYHTianXingBaoGeContainer> CreateFB_SYHTianXingBaoGeContainer(FlatBufferBuilder builder,
      VectorOffset items = default(VectorOffset)) {
    builder.StartObject(1);
    FB_SYHTianXingBaoGeContainer.AddItems(builder, items);
    return FB_SYHTianXingBaoGeContainer.EndFB_SYHTianXingBaoGeContainer(builder);
  }

  public static void StartFB_SYHTianXingBaoGeContainer(FlatBufferBuilder builder) { builder.StartObject(1); }
  public static void AddItems(FlatBufferBuilder builder, VectorOffset itemsOffset) { builder.AddOffset(0, itemsOffset.Value, 0); }
  public static VectorOffset CreateItemsVector(FlatBufferBuilder builder, Offset<FB_SYHTianXingBaoGe>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static void StartItemsVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_SYHTianXingBaoGeContainer> EndFB_SYHTianXingBaoGeContainer(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_SYHTianXingBaoGeContainer>(o);
  }
  public static void FinishFB_SYHTianXingBaoGeContainerBuffer(FlatBufferBuilder builder, Offset<FB_SYHTianXingBaoGeContainer> offset) { builder.Finish(offset.Value, "swdt"); }
};


}
