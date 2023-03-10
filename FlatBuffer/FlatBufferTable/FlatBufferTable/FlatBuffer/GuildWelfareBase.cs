// automatically generated, do not modify

namespace Shark
{

using FlatBuffers;

public sealed class FB_GuildWelfareBase : Table {
  public static FB_GuildWelfareBase GetRootAsFB_GuildWelfareBase(ByteBuffer _bb) { return GetRootAsFB_GuildWelfareBase(_bb, new FB_GuildWelfareBase()); }
  public static FB_GuildWelfareBase GetRootAsFB_GuildWelfareBase(ByteBuffer _bb, FB_GuildWelfareBase obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public FB_GuildWelfareBase __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public int Id { get { int o = __offset(4); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public string Name { get { int o = __offset(6); return o != 0 ? __string(o + bb_pos) : null; } }
  public string Descript { get { int o = __offset(8); return o != 0 ? __string(o + bb_pos) : null; } }
  public int IconItemId { get { int o = __offset(10); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public string BtnName { get { int o = __offset(12); return o != 0 ? __string(o + bb_pos) : null; } }
  public int LogicType { get { int o = __offset(14); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int Param { get { int o = __offset(16); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }

  public static Offset<FB_GuildWelfareBase> CreateFB_GuildWelfareBase(FlatBufferBuilder builder,
      int Id = 0,
      StringOffset Name = default(StringOffset),
      StringOffset Descript = default(StringOffset),
      int IconItemId = 0,
      StringOffset BtnName = default(StringOffset),
      int LogicType = 0,
      int Param = 0) {
    builder.StartObject(7);
    FB_GuildWelfareBase.AddParam(builder, Param);
    FB_GuildWelfareBase.AddLogicType(builder, LogicType);
    FB_GuildWelfareBase.AddBtnName(builder, BtnName);
    FB_GuildWelfareBase.AddIconItemId(builder, IconItemId);
    FB_GuildWelfareBase.AddDescript(builder, Descript);
    FB_GuildWelfareBase.AddName(builder, Name);
    FB_GuildWelfareBase.AddId(builder, Id);
    return FB_GuildWelfareBase.EndFB_GuildWelfareBase(builder);
  }

  public static void StartFB_GuildWelfareBase(FlatBufferBuilder builder) { builder.StartObject(7); }
  public static void AddId(FlatBufferBuilder builder, int Id) { builder.AddInt(0, Id, 0); }
  public static void AddName(FlatBufferBuilder builder, StringOffset NameOffset) { builder.AddOffset(1, NameOffset.Value, 0); }
  public static void AddDescript(FlatBufferBuilder builder, StringOffset DescriptOffset) { builder.AddOffset(2, DescriptOffset.Value, 0); }
  public static void AddIconItemId(FlatBufferBuilder builder, int IconItemId) { builder.AddInt(3, IconItemId, 0); }
  public static void AddBtnName(FlatBufferBuilder builder, StringOffset BtnNameOffset) { builder.AddOffset(4, BtnNameOffset.Value, 0); }
  public static void AddLogicType(FlatBufferBuilder builder, int LogicType) { builder.AddInt(5, LogicType, 0); }
  public static void AddParam(FlatBufferBuilder builder, int Param) { builder.AddInt(6, Param, 0); }
  public static Offset<FB_GuildWelfareBase> EndFB_GuildWelfareBase(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_GuildWelfareBase>(o);
  }
};

public sealed class FB_GuildWelfareBaseContainer : Table {
  public static FB_GuildWelfareBaseContainer GetRootAsFB_GuildWelfareBaseContainer(ByteBuffer _bb) { return GetRootAsFB_GuildWelfareBaseContainer(_bb, new FB_GuildWelfareBaseContainer()); }
  public static FB_GuildWelfareBaseContainer GetRootAsFB_GuildWelfareBaseContainer(ByteBuffer _bb, FB_GuildWelfareBaseContainer obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public static bool FB_GuildWelfareBaseContainerBufferHasIdentifier(ByteBuffer _bb) { return __has_identifier(_bb, "swdt"); }
  public FB_GuildWelfareBaseContainer __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public FB_GuildWelfareBase GetItems(int j) { return GetItems(new FB_GuildWelfareBase(), j); }
  public FB_GuildWelfareBase GetItems(FB_GuildWelfareBase obj, int j) { int o = __offset(4); return o != 0 ? obj.__init(__indirect(__vector(o) + j * 4), bb) : null; }
  public int ItemsLength { get { int o = __offset(4); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_GuildWelfareBaseContainer> CreateFB_GuildWelfareBaseContainer(FlatBufferBuilder builder,
      VectorOffset items = default(VectorOffset)) {
    builder.StartObject(1);
    FB_GuildWelfareBaseContainer.AddItems(builder, items);
    return FB_GuildWelfareBaseContainer.EndFB_GuildWelfareBaseContainer(builder);
  }

  public static void StartFB_GuildWelfareBaseContainer(FlatBufferBuilder builder) { builder.StartObject(1); }
  public static void AddItems(FlatBufferBuilder builder, VectorOffset itemsOffset) { builder.AddOffset(0, itemsOffset.Value, 0); }
  public static VectorOffset CreateItemsVector(FlatBufferBuilder builder, Offset<FB_GuildWelfareBase>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static void StartItemsVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_GuildWelfareBaseContainer> EndFB_GuildWelfareBaseContainer(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_GuildWelfareBaseContainer>(o);
  }
  public static void FinishFB_GuildWelfareBaseContainerBuffer(FlatBufferBuilder builder, Offset<FB_GuildWelfareBaseContainer> offset) { builder.Finish(offset.Value, "swdt"); }
};


}
