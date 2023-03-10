// automatically generated, do not modify

namespace Shark
{

using FlatBuffers;

public sealed class FB_VIPPower : Table {
  public static FB_VIPPower GetRootAsFB_VIPPower(ByteBuffer _bb) { return GetRootAsFB_VIPPower(_bb, new FB_VIPPower()); }
  public static FB_VIPPower GetRootAsFB_VIPPower(ByteBuffer _bb, FB_VIPPower obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public FB_VIPPower __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public int ID { get { int o = __offset(4); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int Exp { get { int o = __offset(6); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public string VIPTitle { get { int o = __offset(8); return o != 0 ? __string(o + bb_pos) : null; } }
  public int StartStrID { get { int o = __offset(10); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int EndStrID { get { int o = __offset(12); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int NoStartStrID { get { int o = __offset(14); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int NoEndStrID { get { int o = __offset(16); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int ImpactId { get { int o = __offset(18); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int TitleId { get { int o = __offset(20); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int ActivateStartStrID { get { int o = __offset(22); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int ActivateEndStrID { get { int o = __offset(24); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }

  public static Offset<FB_VIPPower> CreateFB_VIPPower(FlatBufferBuilder builder,
      int ID = 0,
      int Exp = -1,
      StringOffset VIPTitle = default(StringOffset),
      int StartStrID = -1,
      int EndStrID = -1,
      int NoStartStrID = -1,
      int NoEndStrID = -1,
      int ImpactId = -1,
      int TitleId = -1,
      int ActivateStartStrID = -1,
      int ActivateEndStrID = -1) {
    builder.StartObject(11);
    FB_VIPPower.AddActivateEndStrID(builder, ActivateEndStrID);
    FB_VIPPower.AddActivateStartStrID(builder, ActivateStartStrID);
    FB_VIPPower.AddTitleId(builder, TitleId);
    FB_VIPPower.AddImpactId(builder, ImpactId);
    FB_VIPPower.AddNoEndStrID(builder, NoEndStrID);
    FB_VIPPower.AddNoStartStrID(builder, NoStartStrID);
    FB_VIPPower.AddEndStrID(builder, EndStrID);
    FB_VIPPower.AddStartStrID(builder, StartStrID);
    FB_VIPPower.AddVIPTitle(builder, VIPTitle);
    FB_VIPPower.AddExp(builder, Exp);
    FB_VIPPower.AddID(builder, ID);
    return FB_VIPPower.EndFB_VIPPower(builder);
  }

  public static void StartFB_VIPPower(FlatBufferBuilder builder) { builder.StartObject(11); }
  public static void AddID(FlatBufferBuilder builder, int ID) { builder.AddInt(0, ID, 0); }
  public static void AddExp(FlatBufferBuilder builder, int Exp) { builder.AddInt(1, Exp, -1); }
  public static void AddVIPTitle(FlatBufferBuilder builder, StringOffset VIPTitleOffset) { builder.AddOffset(2, VIPTitleOffset.Value, 0); }
  public static void AddStartStrID(FlatBufferBuilder builder, int StartStrID) { builder.AddInt(3, StartStrID, -1); }
  public static void AddEndStrID(FlatBufferBuilder builder, int EndStrID) { builder.AddInt(4, EndStrID, -1); }
  public static void AddNoStartStrID(FlatBufferBuilder builder, int NoStartStrID) { builder.AddInt(5, NoStartStrID, -1); }
  public static void AddNoEndStrID(FlatBufferBuilder builder, int NoEndStrID) { builder.AddInt(6, NoEndStrID, -1); }
  public static void AddImpactId(FlatBufferBuilder builder, int ImpactId) { builder.AddInt(7, ImpactId, -1); }
  public static void AddTitleId(FlatBufferBuilder builder, int TitleId) { builder.AddInt(8, TitleId, -1); }
  public static void AddActivateStartStrID(FlatBufferBuilder builder, int ActivateStartStrID) { builder.AddInt(9, ActivateStartStrID, -1); }
  public static void AddActivateEndStrID(FlatBufferBuilder builder, int ActivateEndStrID) { builder.AddInt(10, ActivateEndStrID, -1); }
  public static Offset<FB_VIPPower> EndFB_VIPPower(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_VIPPower>(o);
  }
};

public sealed class FB_VIPPowerContainer : Table {
  public static FB_VIPPowerContainer GetRootAsFB_VIPPowerContainer(ByteBuffer _bb) { return GetRootAsFB_VIPPowerContainer(_bb, new FB_VIPPowerContainer()); }
  public static FB_VIPPowerContainer GetRootAsFB_VIPPowerContainer(ByteBuffer _bb, FB_VIPPowerContainer obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public static bool FB_VIPPowerContainerBufferHasIdentifier(ByteBuffer _bb) { return __has_identifier(_bb, "swdt"); }
  public FB_VIPPowerContainer __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public FB_VIPPower GetItems(int j) { return GetItems(new FB_VIPPower(), j); }
  public FB_VIPPower GetItems(FB_VIPPower obj, int j) { int o = __offset(4); return o != 0 ? obj.__init(__indirect(__vector(o) + j * 4), bb) : null; }
  public int ItemsLength { get { int o = __offset(4); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_VIPPowerContainer> CreateFB_VIPPowerContainer(FlatBufferBuilder builder,
      VectorOffset items = default(VectorOffset)) {
    builder.StartObject(1);
    FB_VIPPowerContainer.AddItems(builder, items);
    return FB_VIPPowerContainer.EndFB_VIPPowerContainer(builder);
  }

  public static void StartFB_VIPPowerContainer(FlatBufferBuilder builder) { builder.StartObject(1); }
  public static void AddItems(FlatBufferBuilder builder, VectorOffset itemsOffset) { builder.AddOffset(0, itemsOffset.Value, 0); }
  public static VectorOffset CreateItemsVector(FlatBufferBuilder builder, Offset<FB_VIPPower>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static void StartItemsVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_VIPPowerContainer> EndFB_VIPPowerContainer(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_VIPPowerContainer>(o);
  }
  public static void FinishFB_VIPPowerContainerBuffer(FlatBufferBuilder builder, Offset<FB_VIPPowerContainer> offset) { builder.Finish(offset.Value, "swdt"); }
};


}
