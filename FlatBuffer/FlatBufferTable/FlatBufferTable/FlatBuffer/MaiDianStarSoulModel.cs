// automatically generated, do not modify

namespace Shark
{

using FlatBuffers;

public sealed class FB_MaiDianStarSoulModel : Table {
  public static FB_MaiDianStarSoulModel GetRootAsFB_MaiDianStarSoulModel(ByteBuffer _bb) { return GetRootAsFB_MaiDianStarSoulModel(_bb, new FB_MaiDianStarSoulModel()); }
  public static FB_MaiDianStarSoulModel GetRootAsFB_MaiDianStarSoulModel(ByteBuffer _bb, FB_MaiDianStarSoulModel obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public FB_MaiDianStarSoulModel __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public int ID { get { int o = __offset(4); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int ModelId { get { int o = __offset(6); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int AttrAckAction { get { int o = __offset(8); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int LeisureTime { get { int o = __offset(10); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int BornEffctID { get { int o = __offset(12); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int DisappearEffctID { get { int o = __offset(14); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int UIModelTabId { get { int o = __offset(16); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }

  public static Offset<FB_MaiDianStarSoulModel> CreateFB_MaiDianStarSoulModel(FlatBufferBuilder builder,
      int ID = 0,
      int ModelId = -1,
      int AttrAckAction = -1,
      int leisureTime = -1,
      int BornEffctID = -1,
      int DisappearEffctID = -1,
      int UIModelTabId = -1) {
    builder.StartObject(7);
    FB_MaiDianStarSoulModel.AddUIModelTabId(builder, UIModelTabId);
    FB_MaiDianStarSoulModel.AddDisappearEffctID(builder, DisappearEffctID);
    FB_MaiDianStarSoulModel.AddBornEffctID(builder, BornEffctID);
    FB_MaiDianStarSoulModel.AddLeisureTime(builder, leisureTime);
    FB_MaiDianStarSoulModel.AddAttrAckAction(builder, AttrAckAction);
    FB_MaiDianStarSoulModel.AddModelId(builder, ModelId);
    FB_MaiDianStarSoulModel.AddID(builder, ID);
    return FB_MaiDianStarSoulModel.EndFB_MaiDianStarSoulModel(builder);
  }

  public static void StartFB_MaiDianStarSoulModel(FlatBufferBuilder builder) { builder.StartObject(7); }
  public static void AddID(FlatBufferBuilder builder, int ID) { builder.AddInt(0, ID, 0); }
  public static void AddModelId(FlatBufferBuilder builder, int ModelId) { builder.AddInt(1, ModelId, -1); }
  public static void AddAttrAckAction(FlatBufferBuilder builder, int AttrAckAction) { builder.AddInt(2, AttrAckAction, -1); }
  public static void AddLeisureTime(FlatBufferBuilder builder, int leisureTime) { builder.AddInt(3, leisureTime, -1); }
  public static void AddBornEffctID(FlatBufferBuilder builder, int BornEffctID) { builder.AddInt(4, BornEffctID, -1); }
  public static void AddDisappearEffctID(FlatBufferBuilder builder, int DisappearEffctID) { builder.AddInt(5, DisappearEffctID, -1); }
  public static void AddUIModelTabId(FlatBufferBuilder builder, int UIModelTabId) { builder.AddInt(6, UIModelTabId, -1); }
  public static Offset<FB_MaiDianStarSoulModel> EndFB_MaiDianStarSoulModel(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_MaiDianStarSoulModel>(o);
  }
};

public sealed class FB_MaiDianStarSoulModelContainer : Table {
  public static FB_MaiDianStarSoulModelContainer GetRootAsFB_MaiDianStarSoulModelContainer(ByteBuffer _bb) { return GetRootAsFB_MaiDianStarSoulModelContainer(_bb, new FB_MaiDianStarSoulModelContainer()); }
  public static FB_MaiDianStarSoulModelContainer GetRootAsFB_MaiDianStarSoulModelContainer(ByteBuffer _bb, FB_MaiDianStarSoulModelContainer obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public static bool FB_MaiDianStarSoulModelContainerBufferHasIdentifier(ByteBuffer _bb) { return __has_identifier(_bb, "swdt"); }
  public FB_MaiDianStarSoulModelContainer __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public FB_MaiDianStarSoulModel GetItems(int j) { return GetItems(new FB_MaiDianStarSoulModel(), j); }
  public FB_MaiDianStarSoulModel GetItems(FB_MaiDianStarSoulModel obj, int j) { int o = __offset(4); return o != 0 ? obj.__init(__indirect(__vector(o) + j * 4), bb) : null; }
  public int ItemsLength { get { int o = __offset(4); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_MaiDianStarSoulModelContainer> CreateFB_MaiDianStarSoulModelContainer(FlatBufferBuilder builder,
      VectorOffset items = default(VectorOffset)) {
    builder.StartObject(1);
    FB_MaiDianStarSoulModelContainer.AddItems(builder, items);
    return FB_MaiDianStarSoulModelContainer.EndFB_MaiDianStarSoulModelContainer(builder);
  }

  public static void StartFB_MaiDianStarSoulModelContainer(FlatBufferBuilder builder) { builder.StartObject(1); }
  public static void AddItems(FlatBufferBuilder builder, VectorOffset itemsOffset) { builder.AddOffset(0, itemsOffset.Value, 0); }
  public static VectorOffset CreateItemsVector(FlatBufferBuilder builder, Offset<FB_MaiDianStarSoulModel>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static void StartItemsVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_MaiDianStarSoulModelContainer> EndFB_MaiDianStarSoulModelContainer(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_MaiDianStarSoulModelContainer>(o);
  }
  public static void FinishFB_MaiDianStarSoulModelContainerBuffer(FlatBufferBuilder builder, Offset<FB_MaiDianStarSoulModelContainer> offset) { builder.Finish(offset.Value, "swdt"); }
};


}
