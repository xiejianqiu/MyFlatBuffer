// automatically generated, do not modify

namespace Shark
{

using FlatBuffers;

public sealed class FB_SYHZaDanPingGuo : Table {
  public static FB_SYHZaDanPingGuo GetRootAsFB_SYHZaDanPingGuo(ByteBuffer _bb) { return GetRootAsFB_SYHZaDanPingGuo(_bb, new FB_SYHZaDanPingGuo()); }
  public static FB_SYHZaDanPingGuo GetRootAsFB_SYHZaDanPingGuo(ByteBuffer _bb, FB_SYHZaDanPingGuo obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public FB_SYHZaDanPingGuo __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public int Id { get { int o = __offset(4); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int Type { get { int o = __offset(6); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int Group { get { int o = __offset(8); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int WorldLvMin { get { int o = __offset(10); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int WorldLvMax { get { int o = __offset(12); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int GetQualityList(int j) { int o = __offset(14); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int QualityListLength { get { int o = __offset(14); return o != 0 ? __vector_len(o) : 0; } }
  public int GetWeightList(int j) { int o = __offset(16); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int WeightListLength { get { int o = __offset(16); return o != 0 ? __vector_len(o) : 0; } }
  public int GetRewardList(int j) { int o = __offset(18); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int RewardListLength { get { int o = __offset(18); return o != 0 ? __vector_len(o) : 0; } }
  public int ShowRate { get { int o = __offset(20); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int RewardShow { get { int o = __offset(22); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }

  public static Offset<FB_SYHZaDanPingGuo> CreateFB_SYHZaDanPingGuo(FlatBufferBuilder builder,
      int id = 0,
      int type = -1,
      int group = -1,
      int WorldLvMin = -1,
      int WorldLvMax = -1,
      VectorOffset qualityList = default(VectorOffset),
      VectorOffset weightList = default(VectorOffset),
      VectorOffset rewardList = default(VectorOffset),
      int showRate = -1,
      int rewardShow = -1) {
    builder.StartObject(10);
    FB_SYHZaDanPingGuo.AddRewardShow(builder, rewardShow);
    FB_SYHZaDanPingGuo.AddShowRate(builder, showRate);
    FB_SYHZaDanPingGuo.AddRewardList(builder, rewardList);
    FB_SYHZaDanPingGuo.AddWeightList(builder, weightList);
    FB_SYHZaDanPingGuo.AddQualityList(builder, qualityList);
    FB_SYHZaDanPingGuo.AddWorldLvMax(builder, WorldLvMax);
    FB_SYHZaDanPingGuo.AddWorldLvMin(builder, WorldLvMin);
    FB_SYHZaDanPingGuo.AddGroup(builder, group);
    FB_SYHZaDanPingGuo.AddType(builder, type);
    FB_SYHZaDanPingGuo.AddId(builder, id);
    return FB_SYHZaDanPingGuo.EndFB_SYHZaDanPingGuo(builder);
  }

  public static void StartFB_SYHZaDanPingGuo(FlatBufferBuilder builder) { builder.StartObject(10); }
  public static void AddId(FlatBufferBuilder builder, int id) { builder.AddInt(0, id, 0); }
  public static void AddType(FlatBufferBuilder builder, int type) { builder.AddInt(1, type, -1); }
  public static void AddGroup(FlatBufferBuilder builder, int group) { builder.AddInt(2, group, -1); }
  public static void AddWorldLvMin(FlatBufferBuilder builder, int WorldLvMin) { builder.AddInt(3, WorldLvMin, -1); }
  public static void AddWorldLvMax(FlatBufferBuilder builder, int WorldLvMax) { builder.AddInt(4, WorldLvMax, -1); }
  public static void AddQualityList(FlatBufferBuilder builder, VectorOffset qualityListOffset) { builder.AddOffset(5, qualityListOffset.Value, 0); }
  public static VectorOffset CreateQualityListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartQualityListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddWeightList(FlatBufferBuilder builder, VectorOffset weightListOffset) { builder.AddOffset(6, weightListOffset.Value, 0); }
  public static VectorOffset CreateWeightListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartWeightListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddRewardList(FlatBufferBuilder builder, VectorOffset rewardListOffset) { builder.AddOffset(7, rewardListOffset.Value, 0); }
  public static VectorOffset CreateRewardListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartRewardListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddShowRate(FlatBufferBuilder builder, int showRate) { builder.AddInt(8, showRate, -1); }
  public static void AddRewardShow(FlatBufferBuilder builder, int rewardShow) { builder.AddInt(9, rewardShow, -1); }
  public static Offset<FB_SYHZaDanPingGuo> EndFB_SYHZaDanPingGuo(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_SYHZaDanPingGuo>(o);
  }
};

public sealed class FB_SYHZaDanPingGuoContainer : Table {
  public static FB_SYHZaDanPingGuoContainer GetRootAsFB_SYHZaDanPingGuoContainer(ByteBuffer _bb) { return GetRootAsFB_SYHZaDanPingGuoContainer(_bb, new FB_SYHZaDanPingGuoContainer()); }
  public static FB_SYHZaDanPingGuoContainer GetRootAsFB_SYHZaDanPingGuoContainer(ByteBuffer _bb, FB_SYHZaDanPingGuoContainer obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public static bool FB_SYHZaDanPingGuoContainerBufferHasIdentifier(ByteBuffer _bb) { return __has_identifier(_bb, "swdt"); }
  public FB_SYHZaDanPingGuoContainer __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public FB_SYHZaDanPingGuo GetItems(int j) { return GetItems(new FB_SYHZaDanPingGuo(), j); }
  public FB_SYHZaDanPingGuo GetItems(FB_SYHZaDanPingGuo obj, int j) { int o = __offset(4); return o != 0 ? obj.__init(__indirect(__vector(o) + j * 4), bb) : null; }
  public int ItemsLength { get { int o = __offset(4); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_SYHZaDanPingGuoContainer> CreateFB_SYHZaDanPingGuoContainer(FlatBufferBuilder builder,
      VectorOffset items = default(VectorOffset)) {
    builder.StartObject(1);
    FB_SYHZaDanPingGuoContainer.AddItems(builder, items);
    return FB_SYHZaDanPingGuoContainer.EndFB_SYHZaDanPingGuoContainer(builder);
  }

  public static void StartFB_SYHZaDanPingGuoContainer(FlatBufferBuilder builder) { builder.StartObject(1); }
  public static void AddItems(FlatBufferBuilder builder, VectorOffset itemsOffset) { builder.AddOffset(0, itemsOffset.Value, 0); }
  public static VectorOffset CreateItemsVector(FlatBufferBuilder builder, Offset<FB_SYHZaDanPingGuo>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static void StartItemsVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_SYHZaDanPingGuoContainer> EndFB_SYHZaDanPingGuoContainer(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_SYHZaDanPingGuoContainer>(o);
  }
  public static void FinishFB_SYHZaDanPingGuoContainerBuffer(FlatBufferBuilder builder, Offset<FB_SYHZaDanPingGuoContainer> offset) { builder.Finish(offset.Value, "swdt"); }
};


}
