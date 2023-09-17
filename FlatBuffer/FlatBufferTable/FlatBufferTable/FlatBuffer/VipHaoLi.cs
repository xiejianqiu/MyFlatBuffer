// automatically generated, do not modify

namespace Shark
{

using FlatBuffers;

public sealed class FB_VipHaoLi : Table {
  public static FB_VipHaoLi GetRootAsFB_VipHaoLi(ByteBuffer _bb) { return GetRootAsFB_VipHaoLi(_bb, new FB_VipHaoLi()); }
  public static FB_VipHaoLi GetRootAsFB_VipHaoLi(ByteBuffer _bb, FB_VipHaoLi obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public FB_VipHaoLi __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public int ID { get { int o = __offset(4); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public string Name { get { int o = __offset(6); return o != 0 ? __string(o + bb_pos) : null; } }
  public int GetResPathList(int j) { int o = __offset(8); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int ResPathListLength { get { int o = __offset(8); return o != 0 ? __vector_len(o) : 0; } }
  public string IconPath { get { int o = __offset(10); return o != 0 ? __string(o + bb_pos) : null; } }
  public int IconWidth { get { int o = __offset(12); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int IconHeight { get { int o = __offset(14); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int GetItemIdList(int j) { int o = __offset(16); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int ItemIdListLength { get { int o = __offset(16); return o != 0 ? __vector_len(o) : 0; } }
  public int GetNumberList(int j) { int o = __offset(18); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int NumberListLength { get { int o = __offset(18); return o != 0 ? __vector_len(o) : 0; } }
  public string GetTaskList(int j) { int o = __offset(20); return o != 0 ? __string(__vector(o) + j * 4) : null; }
  public int TaskListLength { get { int o = __offset(20); return o != 0 ? __vector_len(o) : 0; } }
  public int GetTaskTypList(int j) { int o = __offset(22); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int TaskTypListLength { get { int o = __offset(22); return o != 0 ? __vector_len(o) : 0; } }
  public int GetTaskItemList(int j) { int o = __offset(24); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int TaskItemListLength { get { int o = __offset(24); return o != 0 ? __vector_len(o) : 0; } }
  public int GetUiInfoIdList(int j) { int o = __offset(26); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int UiInfoIdListLength { get { int o = __offset(26); return o != 0 ? __vector_len(o) : 0; } }
  public int GetParamIdList(int j) { int o = __offset(28); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int ParamIdListLength { get { int o = __offset(28); return o != 0 ? __vector_len(o) : 0; } }
  public int GetRewardIDList(int j) { int o = __offset(30); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int RewardIDListLength { get { int o = __offset(30); return o != 0 ? __vector_len(o) : 0; } }
  public int GetRewardNumberList(int j) { int o = __offset(32); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int RewardNumberListLength { get { int o = __offset(32); return o != 0 ? __vector_len(o) : 0; } }
  public int Power { get { int o = __offset(34); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }

  public static Offset<FB_VipHaoLi> CreateFB_VipHaoLi(FlatBufferBuilder builder,
      int ID = 0,
      StringOffset Name = default(StringOffset),
      VectorOffset ResPathList = default(VectorOffset),
      StringOffset IconPath = default(StringOffset),
      int IconWidth = 0,
      int IconHeight = 0,
      VectorOffset ItemIdList = default(VectorOffset),
      VectorOffset NumberList = default(VectorOffset),
      VectorOffset TaskList = default(VectorOffset),
      VectorOffset TaskTypList = default(VectorOffset),
      VectorOffset TaskItemList = default(VectorOffset),
      VectorOffset UiInfoIdList = default(VectorOffset),
      VectorOffset ParamIdList = default(VectorOffset),
      VectorOffset RewardIDList = default(VectorOffset),
      VectorOffset RewardNumberList = default(VectorOffset),
      int Power = -1) {
    builder.StartObject(16);
    FB_VipHaoLi.AddPower(builder, Power);
    FB_VipHaoLi.AddRewardNumberList(builder, RewardNumberList);
    FB_VipHaoLi.AddRewardIDList(builder, RewardIDList);
    FB_VipHaoLi.AddParamIdList(builder, ParamIdList);
    FB_VipHaoLi.AddUiInfoIdList(builder, UiInfoIdList);
    FB_VipHaoLi.AddTaskItemList(builder, TaskItemList);
    FB_VipHaoLi.AddTaskTypList(builder, TaskTypList);
    FB_VipHaoLi.AddTaskList(builder, TaskList);
    FB_VipHaoLi.AddNumberList(builder, NumberList);
    FB_VipHaoLi.AddItemIdList(builder, ItemIdList);
    FB_VipHaoLi.AddIconHeight(builder, IconHeight);
    FB_VipHaoLi.AddIconWidth(builder, IconWidth);
    FB_VipHaoLi.AddIconPath(builder, IconPath);
    FB_VipHaoLi.AddResPathList(builder, ResPathList);
    FB_VipHaoLi.AddName(builder, Name);
    FB_VipHaoLi.AddID(builder, ID);
    return FB_VipHaoLi.EndFB_VipHaoLi(builder);
  }

  public static void StartFB_VipHaoLi(FlatBufferBuilder builder) { builder.StartObject(16); }
  public static void AddID(FlatBufferBuilder builder, int ID) { builder.AddInt(0, ID, 0); }
  public static void AddName(FlatBufferBuilder builder, StringOffset NameOffset) { builder.AddOffset(1, NameOffset.Value, 0); }
  public static void AddResPathList(FlatBufferBuilder builder, VectorOffset ResPathListOffset) { builder.AddOffset(2, ResPathListOffset.Value, 0); }
  public static VectorOffset CreateResPathListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartResPathListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddIconPath(FlatBufferBuilder builder, StringOffset IconPathOffset) { builder.AddOffset(3, IconPathOffset.Value, 0); }
  public static void AddIconWidth(FlatBufferBuilder builder, int IconWidth) { builder.AddInt(4, IconWidth, 0); }
  public static void AddIconHeight(FlatBufferBuilder builder, int IconHeight) { builder.AddInt(5, IconHeight, 0); }
  public static void AddItemIdList(FlatBufferBuilder builder, VectorOffset ItemIdListOffset) { builder.AddOffset(6, ItemIdListOffset.Value, 0); }
  public static VectorOffset CreateItemIdListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartItemIdListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddNumberList(FlatBufferBuilder builder, VectorOffset NumberListOffset) { builder.AddOffset(7, NumberListOffset.Value, 0); }
  public static VectorOffset CreateNumberListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartNumberListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddTaskList(FlatBufferBuilder builder, VectorOffset TaskListOffset) { builder.AddOffset(8, TaskListOffset.Value, 0); }
  public static VectorOffset CreateTaskListVector(FlatBufferBuilder builder, StringOffset[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static void StartTaskListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddTaskTypList(FlatBufferBuilder builder, VectorOffset TaskTypListOffset) { builder.AddOffset(9, TaskTypListOffset.Value, 0); }
  public static VectorOffset CreateTaskTypListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartTaskTypListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddTaskItemList(FlatBufferBuilder builder, VectorOffset TaskItemListOffset) { builder.AddOffset(10, TaskItemListOffset.Value, 0); }
  public static VectorOffset CreateTaskItemListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartTaskItemListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddUiInfoIdList(FlatBufferBuilder builder, VectorOffset UiInfoIdListOffset) { builder.AddOffset(11, UiInfoIdListOffset.Value, 0); }
  public static VectorOffset CreateUiInfoIdListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartUiInfoIdListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddParamIdList(FlatBufferBuilder builder, VectorOffset ParamIdListOffset) { builder.AddOffset(12, ParamIdListOffset.Value, 0); }
  public static VectorOffset CreateParamIdListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartParamIdListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddRewardIDList(FlatBufferBuilder builder, VectorOffset RewardIDListOffset) { builder.AddOffset(13, RewardIDListOffset.Value, 0); }
  public static VectorOffset CreateRewardIDListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartRewardIDListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddRewardNumberList(FlatBufferBuilder builder, VectorOffset RewardNumberListOffset) { builder.AddOffset(14, RewardNumberListOffset.Value, 0); }
  public static VectorOffset CreateRewardNumberListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartRewardNumberListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddPower(FlatBufferBuilder builder, int Power) { builder.AddInt(15, Power, -1); }
  public static Offset<FB_VipHaoLi> EndFB_VipHaoLi(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_VipHaoLi>(o);
  }
};

public sealed class FB_VipHaoLiContainer : Table {
  public static FB_VipHaoLiContainer GetRootAsFB_VipHaoLiContainer(ByteBuffer _bb) { return GetRootAsFB_VipHaoLiContainer(_bb, new FB_VipHaoLiContainer()); }
  public static FB_VipHaoLiContainer GetRootAsFB_VipHaoLiContainer(ByteBuffer _bb, FB_VipHaoLiContainer obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public static bool FB_VipHaoLiContainerBufferHasIdentifier(ByteBuffer _bb) { return __has_identifier(_bb, "swdt"); }
  public FB_VipHaoLiContainer __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public FB_VipHaoLi GetItems(int j) { return GetItems(new FB_VipHaoLi(), j); }
  public FB_VipHaoLi GetItems(FB_VipHaoLi obj, int j) { int o = __offset(4); return o != 0 ? obj.__init(__indirect(__vector(o) + j * 4), bb) : null; }
  public int ItemsLength { get { int o = __offset(4); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_VipHaoLiContainer> CreateFB_VipHaoLiContainer(FlatBufferBuilder builder,
      VectorOffset items = default(VectorOffset)) {
    builder.StartObject(1);
    FB_VipHaoLiContainer.AddItems(builder, items);
    return FB_VipHaoLiContainer.EndFB_VipHaoLiContainer(builder);
  }

  public static void StartFB_VipHaoLiContainer(FlatBufferBuilder builder) { builder.StartObject(1); }
  public static void AddItems(FlatBufferBuilder builder, VectorOffset itemsOffset) { builder.AddOffset(0, itemsOffset.Value, 0); }
  public static VectorOffset CreateItemsVector(FlatBufferBuilder builder, Offset<FB_VipHaoLi>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static void StartItemsVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_VipHaoLiContainer> EndFB_VipHaoLiContainer(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_VipHaoLiContainer>(o);
  }
  public static void FinishFB_VipHaoLiContainerBuffer(FlatBufferBuilder builder, Offset<FB_VipHaoLiContainer> offset) { builder.Finish(offset.Value, "swdt"); }
};


}
