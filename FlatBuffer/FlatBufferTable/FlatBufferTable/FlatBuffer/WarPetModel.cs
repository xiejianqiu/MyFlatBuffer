// automatically generated, do not modify

namespace Shark
{

using FlatBuffers;

public sealed class FB_WarPetModel : Table {
  public static FB_WarPetModel GetRootAsFB_WarPetModel(ByteBuffer _bb) { return GetRootAsFB_WarPetModel(_bb, new FB_WarPetModel()); }
  public static FB_WarPetModel GetRootAsFB_WarPetModel(ByteBuffer _bb, FB_WarPetModel obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public FB_WarPetModel __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public int ID { get { int o = __offset(4); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int ModelId { get { int o = __offset(6); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int AttrAckAction { get { int o = __offset(8); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int LeisureTime { get { int o = __offset(10); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int BornEffctID { get { int o = __offset(12); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int DisappearEffctID { get { int o = __offset(14); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int UIModelTabId { get { int o = __offset(16); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }

  public static Offset<FB_WarPetModel> CreateFB_WarPetModel(FlatBufferBuilder builder,
      int ID = 0,
      int ModelId = -1,
      int AttrAckAction = -1,
      int leisureTime = -1,
      int BornEffctID = -1,
      int DisappearEffctID = -1,
      int UIModelTabId = -1) {
    builder.StartObject(7);
    FB_WarPetModel.AddUIModelTabId(builder, UIModelTabId);
    FB_WarPetModel.AddDisappearEffctID(builder, DisappearEffctID);
    FB_WarPetModel.AddBornEffctID(builder, BornEffctID);
    FB_WarPetModel.AddLeisureTime(builder, leisureTime);
    FB_WarPetModel.AddAttrAckAction(builder, AttrAckAction);
    FB_WarPetModel.AddModelId(builder, ModelId);
    FB_WarPetModel.AddID(builder, ID);
    return FB_WarPetModel.EndFB_WarPetModel(builder);
  }

  public static void StartFB_WarPetModel(FlatBufferBuilder builder) { builder.StartObject(7); }
  public static void AddID(FlatBufferBuilder builder, int ID) { builder.AddInt(0, ID, 0); }
  public static void AddModelId(FlatBufferBuilder builder, int ModelId) { builder.AddInt(1, ModelId, -1); }
  public static void AddAttrAckAction(FlatBufferBuilder builder, int AttrAckAction) { builder.AddInt(2, AttrAckAction, -1); }
  public static void AddLeisureTime(FlatBufferBuilder builder, int leisureTime) { builder.AddInt(3, leisureTime, -1); }
  public static void AddBornEffctID(FlatBufferBuilder builder, int BornEffctID) { builder.AddInt(4, BornEffctID, -1); }
  public static void AddDisappearEffctID(FlatBufferBuilder builder, int DisappearEffctID) { builder.AddInt(5, DisappearEffctID, -1); }
  public static void AddUIModelTabId(FlatBufferBuilder builder, int UIModelTabId) { builder.AddInt(6, UIModelTabId, -1); }
  public static Offset<FB_WarPetModel> EndFB_WarPetModel(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_WarPetModel>(o);
  }
};

public sealed class FB_WarPetModelContainer : Table {
  public static FB_WarPetModelContainer GetRootAsFB_WarPetModelContainer(ByteBuffer _bb) { return GetRootAsFB_WarPetModelContainer(_bb, new FB_WarPetModelContainer()); }
  public static FB_WarPetModelContainer GetRootAsFB_WarPetModelContainer(ByteBuffer _bb, FB_WarPetModelContainer obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public static bool FB_WarPetModelContainerBufferHasIdentifier(ByteBuffer _bb) { return __has_identifier(_bb, "swdt"); }
  public FB_WarPetModelContainer __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public FB_WarPetModel GetItems(int j) { return GetItems(new FB_WarPetModel(), j); }
  public FB_WarPetModel GetItems(FB_WarPetModel obj, int j) { int o = __offset(4); return o != 0 ? obj.__init(__indirect(__vector(o) + j * 4), bb) : null; }
  public int ItemsLength { get { int o = __offset(4); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_WarPetModelContainer> CreateFB_WarPetModelContainer(FlatBufferBuilder builder,
      VectorOffset items = default(VectorOffset)) {
    builder.StartObject(1);
    FB_WarPetModelContainer.AddItems(builder, items);
    return FB_WarPetModelContainer.EndFB_WarPetModelContainer(builder);
  }

  public static void StartFB_WarPetModelContainer(FlatBufferBuilder builder) { builder.StartObject(1); }
  public static void AddItems(FlatBufferBuilder builder, VectorOffset itemsOffset) { builder.AddOffset(0, itemsOffset.Value, 0); }
  public static VectorOffset CreateItemsVector(FlatBufferBuilder builder, Offset<FB_WarPetModel>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static void StartItemsVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_WarPetModelContainer> EndFB_WarPetModelContainer(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_WarPetModelContainer>(o);
  }
  public static void FinishFB_WarPetModelContainerBuffer(FlatBufferBuilder builder, Offset<FB_WarPetModelContainer> offset) { builder.Finish(offset.Value, "swdt"); }
};


}
