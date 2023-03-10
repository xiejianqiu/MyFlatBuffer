// automatically generated, do not modify

namespace Shark
{

using FlatBuffers;

public sealed class FB_ShouHuBase : Table {
  public static FB_ShouHuBase GetRootAsFB_ShouHuBase(ByteBuffer _bb) { return GetRootAsFB_ShouHuBase(_bb, new FB_ShouHuBase()); }
  public static FB_ShouHuBase GetRootAsFB_ShouHuBase(ByteBuffer _bb, FB_ShouHuBase obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public FB_ShouHuBase __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public int ID { get { int o = __offset(4); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int RenewNeedYuanBao { get { int o = __offset(6); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int RenewNeedBindYuanBao { get { int o = __offset(8); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public string RenewPanelIcon { get { int o = __offset(10); return o != 0 ? __string(o + bb_pos) : null; } }
  public int CharModelId { get { int o = __offset(12); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int EffectId { get { int o = __offset(14); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int FakeObjId { get { int o = __offset(16); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int FakeObjRenewId { get { int o = __offset(18); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }

  public static Offset<FB_ShouHuBase> CreateFB_ShouHuBase(FlatBufferBuilder builder,
      int ID = 0,
      int RenewNeedYuanBao = -1,
      int RenewNeedBindYuanBao = -1,
      StringOffset RenewPanelIcon = default(StringOffset),
      int CharModelId = -1,
      int EffectId = -1,
      int FakeObjId = -1,
      int FakeObjRenewId = -1) {
    builder.StartObject(8);
    FB_ShouHuBase.AddFakeObjRenewId(builder, FakeObjRenewId);
    FB_ShouHuBase.AddFakeObjId(builder, FakeObjId);
    FB_ShouHuBase.AddEffectId(builder, EffectId);
    FB_ShouHuBase.AddCharModelId(builder, CharModelId);
    FB_ShouHuBase.AddRenewPanelIcon(builder, RenewPanelIcon);
    FB_ShouHuBase.AddRenewNeedBindYuanBao(builder, RenewNeedBindYuanBao);
    FB_ShouHuBase.AddRenewNeedYuanBao(builder, RenewNeedYuanBao);
    FB_ShouHuBase.AddID(builder, ID);
    return FB_ShouHuBase.EndFB_ShouHuBase(builder);
  }

  public static void StartFB_ShouHuBase(FlatBufferBuilder builder) { builder.StartObject(8); }
  public static void AddID(FlatBufferBuilder builder, int ID) { builder.AddInt(0, ID, 0); }
  public static void AddRenewNeedYuanBao(FlatBufferBuilder builder, int RenewNeedYuanBao) { builder.AddInt(1, RenewNeedYuanBao, -1); }
  public static void AddRenewNeedBindYuanBao(FlatBufferBuilder builder, int RenewNeedBindYuanBao) { builder.AddInt(2, RenewNeedBindYuanBao, -1); }
  public static void AddRenewPanelIcon(FlatBufferBuilder builder, StringOffset RenewPanelIconOffset) { builder.AddOffset(3, RenewPanelIconOffset.Value, 0); }
  public static void AddCharModelId(FlatBufferBuilder builder, int CharModelId) { builder.AddInt(4, CharModelId, -1); }
  public static void AddEffectId(FlatBufferBuilder builder, int EffectId) { builder.AddInt(5, EffectId, -1); }
  public static void AddFakeObjId(FlatBufferBuilder builder, int FakeObjId) { builder.AddInt(6, FakeObjId, -1); }
  public static void AddFakeObjRenewId(FlatBufferBuilder builder, int FakeObjRenewId) { builder.AddInt(7, FakeObjRenewId, -1); }
  public static Offset<FB_ShouHuBase> EndFB_ShouHuBase(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_ShouHuBase>(o);
  }
};

public sealed class FB_ShouHuBaseContainer : Table {
  public static FB_ShouHuBaseContainer GetRootAsFB_ShouHuBaseContainer(ByteBuffer _bb) { return GetRootAsFB_ShouHuBaseContainer(_bb, new FB_ShouHuBaseContainer()); }
  public static FB_ShouHuBaseContainer GetRootAsFB_ShouHuBaseContainer(ByteBuffer _bb, FB_ShouHuBaseContainer obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public static bool FB_ShouHuBaseContainerBufferHasIdentifier(ByteBuffer _bb) { return __has_identifier(_bb, "swdt"); }
  public FB_ShouHuBaseContainer __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public FB_ShouHuBase GetItems(int j) { return GetItems(new FB_ShouHuBase(), j); }
  public FB_ShouHuBase GetItems(FB_ShouHuBase obj, int j) { int o = __offset(4); return o != 0 ? obj.__init(__indirect(__vector(o) + j * 4), bb) : null; }
  public int ItemsLength { get { int o = __offset(4); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_ShouHuBaseContainer> CreateFB_ShouHuBaseContainer(FlatBufferBuilder builder,
      VectorOffset items = default(VectorOffset)) {
    builder.StartObject(1);
    FB_ShouHuBaseContainer.AddItems(builder, items);
    return FB_ShouHuBaseContainer.EndFB_ShouHuBaseContainer(builder);
  }

  public static void StartFB_ShouHuBaseContainer(FlatBufferBuilder builder) { builder.StartObject(1); }
  public static void AddItems(FlatBufferBuilder builder, VectorOffset itemsOffset) { builder.AddOffset(0, itemsOffset.Value, 0); }
  public static VectorOffset CreateItemsVector(FlatBufferBuilder builder, Offset<FB_ShouHuBase>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static void StartItemsVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_ShouHuBaseContainer> EndFB_ShouHuBaseContainer(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_ShouHuBaseContainer>(o);
  }
  public static void FinishFB_ShouHuBaseContainerBuffer(FlatBufferBuilder builder, Offset<FB_ShouHuBaseContainer> offset) { builder.Finish(offset.Value, "swdt"); }
};


}
