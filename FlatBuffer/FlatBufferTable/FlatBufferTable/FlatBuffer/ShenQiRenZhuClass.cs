// automatically generated, do not modify

namespace Shark
{

using FlatBuffers;

public sealed class FB_ShenQiRenZhuClass : Table {
  public static FB_ShenQiRenZhuClass GetRootAsFB_ShenQiRenZhuClass(ByteBuffer _bb) { return GetRootAsFB_ShenQiRenZhuClass(_bb, new FB_ShenQiRenZhuClass()); }
  public static FB_ShenQiRenZhuClass GetRootAsFB_ShenQiRenZhuClass(ByteBuffer _bb, FB_ShenQiRenZhuClass obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public FB_ShenQiRenZhuClass __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public int ID { get { int o = __offset(4); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public string Name { get { int o = __offset(6); return o != 0 ? __string(o + bb_pos) : null; } }
  public int GetTypeIdList(int j) { int o = __offset(8); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int TypeIdListLength { get { int o = __offset(8); return o != 0 ? __vector_len(o) : 0; } }
  public int RewardId { get { int o = __offset(10); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public string Introduce { get { int o = __offset(12); return o != 0 ? __string(o + bb_pos) : null; } }
  public string Icon { get { int o = __offset(14); return o != 0 ? __string(o + bb_pos) : null; } }
  public int OpenConditionType { get { int o = __offset(16); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int OpenConditionParam { get { int o = __offset(18); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }

  public static Offset<FB_ShenQiRenZhuClass> CreateFB_ShenQiRenZhuClass(FlatBufferBuilder builder,
      int ID = 0,
      StringOffset Name = default(StringOffset),
      VectorOffset TypeIdList = default(VectorOffset),
      int RewardId = -1,
      StringOffset Introduce = default(StringOffset),
      StringOffset Icon = default(StringOffset),
      int OpenConditionType = 0,
      int OpenConditionParam = 0) {
    builder.StartObject(8);
    FB_ShenQiRenZhuClass.AddOpenConditionParam(builder, OpenConditionParam);
    FB_ShenQiRenZhuClass.AddOpenConditionType(builder, OpenConditionType);
    FB_ShenQiRenZhuClass.AddIcon(builder, Icon);
    FB_ShenQiRenZhuClass.AddIntroduce(builder, Introduce);
    FB_ShenQiRenZhuClass.AddRewardId(builder, RewardId);
    FB_ShenQiRenZhuClass.AddTypeIdList(builder, TypeIdList);
    FB_ShenQiRenZhuClass.AddName(builder, Name);
    FB_ShenQiRenZhuClass.AddID(builder, ID);
    return FB_ShenQiRenZhuClass.EndFB_ShenQiRenZhuClass(builder);
  }

  public static void StartFB_ShenQiRenZhuClass(FlatBufferBuilder builder) { builder.StartObject(8); }
  public static void AddID(FlatBufferBuilder builder, int ID) { builder.AddInt(0, ID, 0); }
  public static void AddName(FlatBufferBuilder builder, StringOffset NameOffset) { builder.AddOffset(1, NameOffset.Value, 0); }
  public static void AddTypeIdList(FlatBufferBuilder builder, VectorOffset TypeIdListOffset) { builder.AddOffset(2, TypeIdListOffset.Value, 0); }
  public static VectorOffset CreateTypeIdListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartTypeIdListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddRewardId(FlatBufferBuilder builder, int RewardId) { builder.AddInt(3, RewardId, -1); }
  public static void AddIntroduce(FlatBufferBuilder builder, StringOffset IntroduceOffset) { builder.AddOffset(4, IntroduceOffset.Value, 0); }
  public static void AddIcon(FlatBufferBuilder builder, StringOffset IconOffset) { builder.AddOffset(5, IconOffset.Value, 0); }
  public static void AddOpenConditionType(FlatBufferBuilder builder, int OpenConditionType) { builder.AddInt(6, OpenConditionType, 0); }
  public static void AddOpenConditionParam(FlatBufferBuilder builder, int OpenConditionParam) { builder.AddInt(7, OpenConditionParam, 0); }
  public static Offset<FB_ShenQiRenZhuClass> EndFB_ShenQiRenZhuClass(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_ShenQiRenZhuClass>(o);
  }
};

public sealed class FB_ShenQiRenZhuClassContainer : Table {
  public static FB_ShenQiRenZhuClassContainer GetRootAsFB_ShenQiRenZhuClassContainer(ByteBuffer _bb) { return GetRootAsFB_ShenQiRenZhuClassContainer(_bb, new FB_ShenQiRenZhuClassContainer()); }
  public static FB_ShenQiRenZhuClassContainer GetRootAsFB_ShenQiRenZhuClassContainer(ByteBuffer _bb, FB_ShenQiRenZhuClassContainer obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public static bool FB_ShenQiRenZhuClassContainerBufferHasIdentifier(ByteBuffer _bb) { return __has_identifier(_bb, "swdt"); }
  public FB_ShenQiRenZhuClassContainer __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public FB_ShenQiRenZhuClass GetItems(int j) { return GetItems(new FB_ShenQiRenZhuClass(), j); }
  public FB_ShenQiRenZhuClass GetItems(FB_ShenQiRenZhuClass obj, int j) { int o = __offset(4); return o != 0 ? obj.__init(__indirect(__vector(o) + j * 4), bb) : null; }
  public int ItemsLength { get { int o = __offset(4); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_ShenQiRenZhuClassContainer> CreateFB_ShenQiRenZhuClassContainer(FlatBufferBuilder builder,
      VectorOffset items = default(VectorOffset)) {
    builder.StartObject(1);
    FB_ShenQiRenZhuClassContainer.AddItems(builder, items);
    return FB_ShenQiRenZhuClassContainer.EndFB_ShenQiRenZhuClassContainer(builder);
  }

  public static void StartFB_ShenQiRenZhuClassContainer(FlatBufferBuilder builder) { builder.StartObject(1); }
  public static void AddItems(FlatBufferBuilder builder, VectorOffset itemsOffset) { builder.AddOffset(0, itemsOffset.Value, 0); }
  public static VectorOffset CreateItemsVector(FlatBufferBuilder builder, Offset<FB_ShenQiRenZhuClass>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static void StartItemsVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_ShenQiRenZhuClassContainer> EndFB_ShenQiRenZhuClassContainer(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_ShenQiRenZhuClassContainer>(o);
  }
  public static void FinishFB_ShenQiRenZhuClassContainerBuffer(FlatBufferBuilder builder, Offset<FB_ShenQiRenZhuClassContainer> offset) { builder.Finish(offset.Value, "swdt"); }
};


}
