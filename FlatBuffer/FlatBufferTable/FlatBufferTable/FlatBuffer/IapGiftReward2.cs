// automatically generated, do not modify

namespace Shark
{

using FlatBuffers;

public sealed class FB_IapGiftReward2 : Table {
  public static FB_IapGiftReward2 GetRootAsFB_IapGiftReward2(ByteBuffer _bb) { return GetRootAsFB_IapGiftReward2(_bb, new FB_IapGiftReward2()); }
  public static FB_IapGiftReward2 GetRootAsFB_IapGiftReward2(ByteBuffer _bb, FB_IapGiftReward2 obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public FB_IapGiftReward2 __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public int Id { get { int o = __offset(4); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public string Des2c { get { int o = __offset(6); return o != 0 ? __string(o + bb_pos) : null; } }
  public int RefreshType { get { int o = __offset(8); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int Related { get { int o = __offset(10); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int LimitValue { get { int o = __offset(12); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int ShowModel { get { int o = __offset(14); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int Infor { get { int o = __offset(16); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public string ShowPassiveSkillMain { get { int o = __offset(18); return o != 0 ? __string(o + bb_pos) : null; } }
  public string ShowPassiveSkillMinor { get { int o = __offset(20); return o != 0 ? __string(o + bb_pos) : null; } }
  public int GetItemIdList(int j) { int o = __offset(22); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int ItemIdListLength { get { int o = __offset(22); return o != 0 ? __vector_len(o) : 0; } }
  public int GetItemCountList(int j) { int o = __offset(24); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int ItemCountListLength { get { int o = __offset(24); return o != 0 ? __vector_len(o) : 0; } }
  public int GetDailyItemIdList(int j) { int o = __offset(26); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int DailyItemIdListLength { get { int o = __offset(26); return o != 0 ? __vector_len(o) : 0; } }
  public int GetDailyItemCountList(int j) { int o = __offset(28); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int DailyItemCountListLength { get { int o = __offset(28); return o != 0 ? __vector_len(o) : 0; } }
  public string Name { get { int o = __offset(30); return o != 0 ? __string(o + bb_pos) : null; } }

  public static Offset<FB_IapGiftReward2> CreateFB_IapGiftReward2(FlatBufferBuilder builder,
      int Id = 0,
      StringOffset Des2c = default(StringOffset),
      int RefreshType = 0,
      int related = 0,
      int LimitValue = 0,
      int showModel = 0,
      int infor = 0,
      StringOffset showPassiveSkillMain = default(StringOffset),
      StringOffset showPassiveSkillMinor = default(StringOffset),
      VectorOffset ItemIdList = default(VectorOffset),
      VectorOffset ItemCountList = default(VectorOffset),
      VectorOffset DailyItemIdList = default(VectorOffset),
      VectorOffset DailyItemCountList = default(VectorOffset),
      StringOffset name = default(StringOffset)) {
    builder.StartObject(14);
    FB_IapGiftReward2.AddName(builder, name);
    FB_IapGiftReward2.AddDailyItemCountList(builder, DailyItemCountList);
    FB_IapGiftReward2.AddDailyItemIdList(builder, DailyItemIdList);
    FB_IapGiftReward2.AddItemCountList(builder, ItemCountList);
    FB_IapGiftReward2.AddItemIdList(builder, ItemIdList);
    FB_IapGiftReward2.AddShowPassiveSkillMinor(builder, showPassiveSkillMinor);
    FB_IapGiftReward2.AddShowPassiveSkillMain(builder, showPassiveSkillMain);
    FB_IapGiftReward2.AddInfor(builder, infor);
    FB_IapGiftReward2.AddShowModel(builder, showModel);
    FB_IapGiftReward2.AddLimitValue(builder, LimitValue);
    FB_IapGiftReward2.AddRelated(builder, related);
    FB_IapGiftReward2.AddRefreshType(builder, RefreshType);
    FB_IapGiftReward2.AddDes2c(builder, Des2c);
    FB_IapGiftReward2.AddId(builder, Id);
    return FB_IapGiftReward2.EndFB_IapGiftReward2(builder);
  }

  public static void StartFB_IapGiftReward2(FlatBufferBuilder builder) { builder.StartObject(14); }
  public static void AddId(FlatBufferBuilder builder, int Id) { builder.AddInt(0, Id, 0); }
  public static void AddDes2c(FlatBufferBuilder builder, StringOffset Des2cOffset) { builder.AddOffset(1, Des2cOffset.Value, 0); }
  public static void AddRefreshType(FlatBufferBuilder builder, int RefreshType) { builder.AddInt(2, RefreshType, 0); }
  public static void AddRelated(FlatBufferBuilder builder, int related) { builder.AddInt(3, related, 0); }
  public static void AddLimitValue(FlatBufferBuilder builder, int LimitValue) { builder.AddInt(4, LimitValue, 0); }
  public static void AddShowModel(FlatBufferBuilder builder, int showModel) { builder.AddInt(5, showModel, 0); }
  public static void AddInfor(FlatBufferBuilder builder, int infor) { builder.AddInt(6, infor, 0); }
  public static void AddShowPassiveSkillMain(FlatBufferBuilder builder, StringOffset showPassiveSkillMainOffset) { builder.AddOffset(7, showPassiveSkillMainOffset.Value, 0); }
  public static void AddShowPassiveSkillMinor(FlatBufferBuilder builder, StringOffset showPassiveSkillMinorOffset) { builder.AddOffset(8, showPassiveSkillMinorOffset.Value, 0); }
  public static void AddItemIdList(FlatBufferBuilder builder, VectorOffset ItemIdListOffset) { builder.AddOffset(9, ItemIdListOffset.Value, 0); }
  public static VectorOffset CreateItemIdListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartItemIdListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddItemCountList(FlatBufferBuilder builder, VectorOffset ItemCountListOffset) { builder.AddOffset(10, ItemCountListOffset.Value, 0); }
  public static VectorOffset CreateItemCountListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartItemCountListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddDailyItemIdList(FlatBufferBuilder builder, VectorOffset DailyItemIdListOffset) { builder.AddOffset(11, DailyItemIdListOffset.Value, 0); }
  public static VectorOffset CreateDailyItemIdListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartDailyItemIdListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddDailyItemCountList(FlatBufferBuilder builder, VectorOffset DailyItemCountListOffset) { builder.AddOffset(12, DailyItemCountListOffset.Value, 0); }
  public static VectorOffset CreateDailyItemCountListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartDailyItemCountListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddName(FlatBufferBuilder builder, StringOffset nameOffset) { builder.AddOffset(13, nameOffset.Value, 0); }
  public static Offset<FB_IapGiftReward2> EndFB_IapGiftReward2(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_IapGiftReward2>(o);
  }
};

public sealed class FB_IapGiftReward2Container : Table {
  public static FB_IapGiftReward2Container GetRootAsFB_IapGiftReward2Container(ByteBuffer _bb) { return GetRootAsFB_IapGiftReward2Container(_bb, new FB_IapGiftReward2Container()); }
  public static FB_IapGiftReward2Container GetRootAsFB_IapGiftReward2Container(ByteBuffer _bb, FB_IapGiftReward2Container obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public static bool FB_IapGiftReward2ContainerBufferHasIdentifier(ByteBuffer _bb) { return __has_identifier(_bb, "swdt"); }
  public FB_IapGiftReward2Container __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public FB_IapGiftReward2 GetItems(int j) { return GetItems(new FB_IapGiftReward2(), j); }
  public FB_IapGiftReward2 GetItems(FB_IapGiftReward2 obj, int j) { int o = __offset(4); return o != 0 ? obj.__init(__indirect(__vector(o) + j * 4), bb) : null; }
  public int ItemsLength { get { int o = __offset(4); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_IapGiftReward2Container> CreateFB_IapGiftReward2Container(FlatBufferBuilder builder,
      VectorOffset items = default(VectorOffset)) {
    builder.StartObject(1);
    FB_IapGiftReward2Container.AddItems(builder, items);
    return FB_IapGiftReward2Container.EndFB_IapGiftReward2Container(builder);
  }

  public static void StartFB_IapGiftReward2Container(FlatBufferBuilder builder) { builder.StartObject(1); }
  public static void AddItems(FlatBufferBuilder builder, VectorOffset itemsOffset) { builder.AddOffset(0, itemsOffset.Value, 0); }
  public static VectorOffset CreateItemsVector(FlatBufferBuilder builder, Offset<FB_IapGiftReward2>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static void StartItemsVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_IapGiftReward2Container> EndFB_IapGiftReward2Container(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_IapGiftReward2Container>(o);
  }
  public static void FinishFB_IapGiftReward2ContainerBuffer(FlatBufferBuilder builder, Offset<FB_IapGiftReward2Container> offset) { builder.Finish(offset.Value, "swdt"); }
};


}
