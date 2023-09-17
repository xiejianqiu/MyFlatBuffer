// automatically generated, do not modify

namespace Shark
{

using FlatBuffers;

public sealed class FB_TaoZhuangModel : Table {
  public static FB_TaoZhuangModel GetRootAsFB_TaoZhuangModel(ByteBuffer _bb) { return GetRootAsFB_TaoZhuangModel(_bb, new FB_TaoZhuangModel()); }
  public static FB_TaoZhuangModel GetRootAsFB_TaoZhuangModel(ByteBuffer _bb, FB_TaoZhuangModel obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public FB_TaoZhuangModel __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public int ID { get { int o = __offset(4); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int GetHairModelIDList(int j) { int o = __offset(6); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int HairModelIDListLength { get { int o = __offset(6); return o != 0 ? __vector_len(o) : 0; } }
  public int GetWeaponModelIDList(int j) { int o = __offset(8); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int WeaponModelIDListLength { get { int o = __offset(8); return o != 0 ? __vector_len(o) : 0; } }
  public int GetCharModelIDList(int j) { int o = __offset(10); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int CharModelIDListLength { get { int o = __offset(10); return o != 0 ? __vector_len(o) : 0; } }
  public int WingID { get { int o = __offset(12); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int MountID { get { int o = __offset(14); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int GetPeiShiList(int j) { int o = __offset(16); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int PeiShiListLength { get { int o = __offset(16); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_TaoZhuangModel> CreateFB_TaoZhuangModel(FlatBufferBuilder builder,
      int ID = 0,
      VectorOffset HairModelIDList = default(VectorOffset),
      VectorOffset WeaponModelIDList = default(VectorOffset),
      VectorOffset CharModelIDList = default(VectorOffset),
      int WingID = -1,
      int MountID = -1,
      VectorOffset PeiShiList = default(VectorOffset)) {
    builder.StartObject(7);
    FB_TaoZhuangModel.AddPeiShiList(builder, PeiShiList);
    FB_TaoZhuangModel.AddMountID(builder, MountID);
    FB_TaoZhuangModel.AddWingID(builder, WingID);
    FB_TaoZhuangModel.AddCharModelIDList(builder, CharModelIDList);
    FB_TaoZhuangModel.AddWeaponModelIDList(builder, WeaponModelIDList);
    FB_TaoZhuangModel.AddHairModelIDList(builder, HairModelIDList);
    FB_TaoZhuangModel.AddID(builder, ID);
    return FB_TaoZhuangModel.EndFB_TaoZhuangModel(builder);
  }

  public static void StartFB_TaoZhuangModel(FlatBufferBuilder builder) { builder.StartObject(7); }
  public static void AddID(FlatBufferBuilder builder, int ID) { builder.AddInt(0, ID, 0); }
  public static void AddHairModelIDList(FlatBufferBuilder builder, VectorOffset HairModelIDListOffset) { builder.AddOffset(1, HairModelIDListOffset.Value, 0); }
  public static VectorOffset CreateHairModelIDListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartHairModelIDListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddWeaponModelIDList(FlatBufferBuilder builder, VectorOffset WeaponModelIDListOffset) { builder.AddOffset(2, WeaponModelIDListOffset.Value, 0); }
  public static VectorOffset CreateWeaponModelIDListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartWeaponModelIDListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddCharModelIDList(FlatBufferBuilder builder, VectorOffset CharModelIDListOffset) { builder.AddOffset(3, CharModelIDListOffset.Value, 0); }
  public static VectorOffset CreateCharModelIDListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartCharModelIDListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddWingID(FlatBufferBuilder builder, int WingID) { builder.AddInt(4, WingID, -1); }
  public static void AddMountID(FlatBufferBuilder builder, int MountID) { builder.AddInt(5, MountID, -1); }
  public static void AddPeiShiList(FlatBufferBuilder builder, VectorOffset PeiShiListOffset) { builder.AddOffset(6, PeiShiListOffset.Value, 0); }
  public static VectorOffset CreatePeiShiListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartPeiShiListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_TaoZhuangModel> EndFB_TaoZhuangModel(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_TaoZhuangModel>(o);
  }
};

public sealed class FB_TaoZhuangModelContainer : Table {
  public static FB_TaoZhuangModelContainer GetRootAsFB_TaoZhuangModelContainer(ByteBuffer _bb) { return GetRootAsFB_TaoZhuangModelContainer(_bb, new FB_TaoZhuangModelContainer()); }
  public static FB_TaoZhuangModelContainer GetRootAsFB_TaoZhuangModelContainer(ByteBuffer _bb, FB_TaoZhuangModelContainer obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public static bool FB_TaoZhuangModelContainerBufferHasIdentifier(ByteBuffer _bb) { return __has_identifier(_bb, "swdt"); }
  public FB_TaoZhuangModelContainer __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public FB_TaoZhuangModel GetItems(int j) { return GetItems(new FB_TaoZhuangModel(), j); }
  public FB_TaoZhuangModel GetItems(FB_TaoZhuangModel obj, int j) { int o = __offset(4); return o != 0 ? obj.__init(__indirect(__vector(o) + j * 4), bb) : null; }
  public int ItemsLength { get { int o = __offset(4); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_TaoZhuangModelContainer> CreateFB_TaoZhuangModelContainer(FlatBufferBuilder builder,
      VectorOffset items = default(VectorOffset)) {
    builder.StartObject(1);
    FB_TaoZhuangModelContainer.AddItems(builder, items);
    return FB_TaoZhuangModelContainer.EndFB_TaoZhuangModelContainer(builder);
  }

  public static void StartFB_TaoZhuangModelContainer(FlatBufferBuilder builder) { builder.StartObject(1); }
  public static void AddItems(FlatBufferBuilder builder, VectorOffset itemsOffset) { builder.AddOffset(0, itemsOffset.Value, 0); }
  public static VectorOffset CreateItemsVector(FlatBufferBuilder builder, Offset<FB_TaoZhuangModel>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static void StartItemsVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_TaoZhuangModelContainer> EndFB_TaoZhuangModelContainer(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_TaoZhuangModelContainer>(o);
  }
  public static void FinishFB_TaoZhuangModelContainerBuffer(FlatBufferBuilder builder, Offset<FB_TaoZhuangModelContainer> offset) { builder.Finish(offset.Value, "swdt"); }
};


}
